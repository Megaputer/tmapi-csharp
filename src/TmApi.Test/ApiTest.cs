using System;
using System.Diagnostics;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using TmApi.Client;
using TmApi.Api;
using TmApi.Model;

namespace TmApi.Test
{
    [TestFixture]
    public class ApiTest
    {
        private List<String> testTexts = new List<String>()
        {
            "Elvis Presley was born in Tupelo, Mississippi.",
            "Elvis Presley was an American singer"
        };

        public static string Base64Encode(String plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static Documents GetDocuments(List<String> texts)
        {
            var files = new List<Document>();
            foreach (String text in texts)
                files.Add(new Document(Base64Encode(text)));
            return new Documents(files);
        }

        [SetUp]
        public void Init()
        {
            Configuration.Default.Username = "user";
            Configuration.Default.Password = "";
            Configuration.Default.BasePath = "http://localhost:7007/tmapi/v1";
        }

        [TearDown]
        public void Cleanup()
        {
        }

        // server
        [Test]
        public void TestServerInfo()
        {
            var api = new ServerApi();
            var info = api.GetServerInfo();
            Assert.IsTrue(info.Languages.Count > 0);
            Assert.IsTrue(info.Operations.Count > 0);
        }

        // limits
        [Test]
        public void TestServerLimits()
        {
            var api = new LimitsApi();
            // check no exceptions
            api.GetLimits();
        }

        // language
        [Test]
        public void TestDetectLanguage()
        {
            var api = new OperationsApi();
            var res = api.GetLanguages(testTexts[0]);
            Assert.IsTrue(res.Documents.Count == 1);
            Assert.IsTrue(res.Documents[0].Language == "English");
        }

        [Test]
        public void TestDetectDocumentsLanguage()
        {
            var api = new OperationsApi();
            var documents = GetDocuments(testTexts);
            var res = api.GetDocumentsLanguages(documents);
            Assert.IsTrue(res.Documents.Count == documents.Files.Count);
            foreach (var doc in res.Documents)
                Assert.IsTrue(doc.Language == "English");
        }

        // tokens
        [Test]
        public void TestTokens()
        {
            var api = new OperationsApi();
            var res = api.ExtractTokens(testTexts[0]);
            Assert.IsTrue(res.Documents.Count == 1);
            Assert.IsTrue(res.Documents[0].Sentences.Count > 0);
            Assert.IsTrue(res.Documents[0].Sentences[0].Tokens.Count > 0);
        }

        [Test]
        public void TestDocumentTokens()
        {
            var api = new OperationsApi();
            var documents = GetDocuments(testTexts);
            var res = api.ExtractDocumentsTokens(documents);
            Assert.IsTrue(res.Documents.Count == documents.Files.Count);
            foreach (var doc in res.Documents)
            {
                Assert.IsTrue(doc.Sentences.Count > 0);
                Assert.IsTrue(doc.Sentences[0].Tokens.Count > 0);
            }
        }

        // keywords
        [Test]
        public void TestKeywords()
        {
            var api = new OperationsApi();
            var res = api.ExtractKeywords(testTexts[0]);
            Assert.IsTrue(res.Documents.Count == 1);
            Assert.IsTrue(res.Documents[0].Keywords.Count > 0);
        }

        [Test]
        public void TestDocumentKeywords()
        {
            var api = new OperationsApi();
            var documents = GetDocuments(testTexts);
            var res = api.ExtractDocumentsKeywords(documents);
            Assert.IsTrue(res.Documents.Count == documents.Files.Count);
            foreach (var doc in res.Documents)
                Assert.IsTrue(doc.Keywords.Count > 0);
        }

        // entities
        [Test]
        public void TestEntities()
        {
            var api = new OperationsApi();
            var res = api.ExtractEntities(testTexts[0]);
            Assert.IsTrue(res.Documents.Count == 1);
            Assert.IsTrue(res.Documents[0].Entities.Count > 0);
        }

        [Test]
        public void TestDocumentEntities()
        {
            var api = new OperationsApi();
            var documents = GetDocuments(testTexts);
            var res = api.ExtractDocumentsEntities(documents);
            Assert.IsTrue(res.Documents.Count == documents.Files.Count);
            foreach (var doc in res.Documents)
                Assert.IsTrue(doc.Entities.Count > 0);
        }

        // sentiments
        private List<String> sentimentsTexts = new List<String>()
        {
            "New menu is good but the place in Toronto is dirty.",
            "Pretty good food on average"
        };

        [Test]
        public void TestSentiments()
        {
            var api = new OperationsApi();
            var res = api.ExtractSentiments(sentimentsTexts[0]);
            Assert.IsTrue(res.Documents.Count == 1);
            Assert.IsTrue(res.Documents[0].Sentiments.Count > 0);
        }

        [Test]
        public void TestDocumentSentiments()
        {
            var api = new OperationsApi();
            var documents = GetDocuments(sentimentsTexts);
            var res = api.ExtractDocumentsSentiments(documents);
            Assert.IsTrue(res.Documents.Count == documents.Files.Count);
            foreach (var doc in res.Documents)
                Assert.IsTrue(doc.Sentiments.Count > 0);
        }

        // facts
        [Test]
        public void TestFacts()
        {
            var api = new OperationsApi();
            var res = api.ExtractFacts(testTexts[0]);
            Assert.IsTrue(res.Documents.Count == 1);
            Assert.IsTrue(res.Documents[0].Facts.Count > 0);
        }

        [Test]
        public void TestDocumentFacts()
        {
            var api = new OperationsApi();
            var documents = GetDocuments(testTexts);
            var res = api.ExtractDocumentsFacts(documents);
            Assert.IsTrue(res.Documents.Count == documents.Files.Count);
            foreach (var doc in res.Documents)
                Assert.IsTrue(doc.Facts.Count > 0);
        }

        // tasks
        [Test]
        public void TestTaskInfo()
        {
            var api = new TasksApi();
            var documents = GetDocuments(testTexts);
            var res = api.CreateTask(new List<String>(){"tokens"}, documents, 1);
            var taskId = ((JObject)res).GetValue("taskId").ToString();
            // all tasks
            var all = api.GetTasksInfo(new List<String>());
            var bFound = false;
            foreach (var task in all.Tasks)
            {
                if (task.Id == taskId)
                {
                    bFound = true;
                    break;
                }
            }
            Assert.IsTrue(bFound);
            // concrete task
            var info = api.GetTasksInfo(new List<String>() { taskId });
            Assert.IsTrue(info.Tasks[0].Id == taskId);
        }

        [Test]
        public void TestDeleteTask()
        {
            var api = new TasksApi();
            var documents = GetDocuments(testTexts);
            var res = api.CreateTask(new List<String>() { "tokens" }, documents, 1);
            var taskId = ((JObject)res).GetValue("taskId").ToString();
            var info = api.GetTasksInfo(new List<String>() { taskId });
            Assert.IsTrue(info.Tasks.Count == 1);
            api.DeleteTasks(new List<String>() { taskId });
            info = api.GetTasksInfo(new List<String>() { taskId });
            Assert.IsTrue(info.Tasks == null || info.Tasks.Count == 0);
        }

        [Test]
        public void TestSyncTask()
        {
            var api = new TasksApi();
            var documents = GetDocuments(testTexts);
            var res = api.CreateTask(new List<String>() { "entities" }, documents, 0);
            var entities = JsonConvert.DeserializeObject<EntitiesResponse>(res.ToString());
            Assert.IsTrue(entities.Documents.Count == documents.Files.Count);
            foreach (var doc in entities.Documents)
                Assert.IsTrue(doc.Entities.Count > 0);
        }

        [Test]
        public void TestAsyncTask()
        {
            var api = new TasksApi();
            var documents = GetDocuments(testTexts);
            var res = api.CreateTask(new List<String>() { "entities" }, documents, 1);
            var taskId = ((JObject)res).GetValue("taskId").ToString();
            while (true)
            {
                var info = api.GetTasksInfo(new List<String>() { taskId });
                if (info.Tasks[0].Done == 100)
                    break;
            }
            var resEntities = api.GetTaskResult(taskId, new List<String>() { "entities" });
            var entities = JsonConvert.DeserializeObject<EntitiesResponse>(resEntities.ToString());
            Assert.IsTrue(entities.Documents.Count == documents.Files.Count);
            foreach (var doc in entities.Documents)
                Assert.IsTrue(doc.Entities.Count > 0);
        }

        [Test]
        public void TestMultipleTask()
        {
            var api = new TasksApi();
            var documents = GetDocuments(testTexts);
            var operations = new List<String>() { "tokens", "entities" };
            // create task
            var res = api.CreateTask(operations, documents, 1);
            var taskId = ((JObject)res).GetValue("taskId").ToString();            
            // wait till finished            
            while (true)
            {
                var info = api.GetTasksInfo(new List<String>() { taskId });
                if (info.Tasks[0].Done == 100)
                    break;
            }
            // check results
            for (var i = 0; i < operations.Count; i++)
            {
                var taskRes = api.GetTaskResult(taskId, new List<String>() { operations[i] });
                var docs = JsonConvert.DeserializeObject<EntitiesResponse>(taskRes.ToString());
                Assert.IsTrue(docs.Documents.Count == documents.Files.Count);
            }
        }
    }
}