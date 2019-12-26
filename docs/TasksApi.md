# TmApi.Api.TasksApi

All URIs are relative to *https://localhost:7008/tmapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTask**](TasksApi.md#createtask) | **POST** /tasks | Create task
[**DeleteTasks**](TasksApi.md#deletetasks) | **DELETE** /tasks | Delete tasks
[**GetTaskResult**](TasksApi.md#gettaskresult) | **GET** /tasks/result | Task result
[**GetTasksInfo**](TasksApi.md#gettasksinfo) | **GET** /tasks | Tasks information


<a name="createtask"></a>
# **CreateTask**
> Object CreateTask (List<string> operations, Documents documents, int? async = null, string positions = null)

Create task

To create a task for performing several operations with text documents, specify required operations in the \"operations\" attribute in the request body. Tasks should be separated by a comma. The list of operations supported with the server could be retrieved via the request \"server\".  Created tasks are available to users until they are deleted by the DELETE method or the server is restarted. After restarting the server it is not possible to get information, to delete, or to get the result of the created tasks. The tasks will cease to exist as if they were deleted by the DELETE method. 

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class CreateTaskExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var operations = ["tokens"];  // List<string> | List of operations (languages, tokens, keywords, entities, sentiments, facts)
            var documents = new Documents(); // Documents | Documents to process
            var async = 1;  // int? | Asynchorous execution flag: * `0` - Block execution until result is ready (**default**) * `1` - Return GUID of newly created task and run task asynchronously  (optional) 
            var positions = "none"; // string | Positions format to be returned from server: - `none` - Don't return positions (**default**) - `symbol` - Symbol positions - `token` - Token positions  (optional) 

            try
            {
                // Create task
                Object result = apiInstance.CreateTask(operations, documents, async, positions);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **operations** | **List&lt;string&gt;**| List of operations (languages, tokens, keywords, entities, sentiments, facts) | 
 **documents** | [**Documents**](Documents.md)| Documents to process | 
 **async** | **int?**| Asynchorous execution flag: * &#x60;0&#x60; - Block execution until result is ready (**default**) * &#x60;1&#x60; - Return GUID of newly created task and run task asynchronously  | [optional] 
 **positions** | **string**| Positions format to be returned from server: - &#x60;none&#x60; - Don&#39;t return positions (**default**) - &#x60;symbol&#x60; - Symbol positions - &#x60;token&#x60; - Token positions  | [optional] 

### Return type

**Object**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetasks"></a>
# **DeleteTasks**
> Object DeleteTasks (List<string> ids)

Delete tasks

The operation allows to delete current user’s tasks specified in the ids parameter. Deleting tasks saves the server disk space. 

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class DeleteTasksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var ids = new List<string>(); // List<string> | List of task identifiers

            try
            {
                // Delete tasks
                Object result = apiInstance.DeleteTasks(ids);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;string&gt;**](string.md)| List of task identifiers | 

### Return type

**Object**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskresult"></a>
# **GetTaskResult**
> Object GetTaskResult (string id, List<string> operations, string positions = null)

Task result

The operation allows to get the result of the specified task. The task GUID and relevant operations are required.  Before getting results of the task execution, first ensure that the task is completed (the done paremeter is 100, the error parameter is empty). 

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class GetTaskResultExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var id = "FEFC8383-D7DB-4557-AFBA-D96CA9CD5808"; // string | Task identifier
            var operations = ["tokens"];  // List<string> | List of operations (languages, tokens, keywords, entities, sentiments, facts)
            var positions = "none"; // string | Positions format to be returned from server: - `none` - Don't return positions (**default**) - `symbol` - Symbol positions - `token` - Token positions  (optional) 

            try
            {
                // Task result
                Object result = apiInstance.GetTaskResult(id, operations, positions);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Task identifier | 
 **operations** | **List&lt;string&gt;**| List of operations (languages, tokens, keywords, entities, sentiments, facts) | 
 **positions** | **string**| Positions format to be returned from server: - &#x60;none&#x60; - Don&#39;t return positions (**default**) - &#x60;symbol&#x60; - Symbol positions - &#x60;token&#x60; - Token positions  | [optional] 

### Return type

**Object**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasksinfo"></a>
# **GetTasksInfo**
> TaskInfo GetTasksInfo (List<string> ids)

Tasks information

The operation allows to receive information about the specified tasks. A task unique identifier (GIUD) is required, which is returned when creating new asynchronous task. If the identifiers list is empty, the server will return information about all tasks of the current user. 

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class GetTasksInfoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var ids = new List<string>(); // List<string> | List of task identifiers

            try
            {
                // Tasks information
                TaskInfo result = apiInstance.GetTasksInfo(ids);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasksInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;string&gt;**](string.md)| List of task identifiers | 

### Return type

[**TaskInfo**](TaskInfo.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

