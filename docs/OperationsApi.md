# TmApi.Api.OperationsApi

All URIs are relative to *https://localhost:7008/tmapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExtractDocumentsEntities**](OperationsApi.md#extractdocumentsentities) | **POST** /operations/entities | Entities extraction
[**ExtractDocumentsFacts**](OperationsApi.md#extractdocumentsfacts) | **POST** /operations/facts | Facts extraction
[**ExtractDocumentsKeywords**](OperationsApi.md#extractdocumentskeywords) | **POST** /operations/keywords | Keywords extraction
[**ExtractDocumentsSentiments**](OperationsApi.md#extractdocumentssentiments) | **POST** /operations/sentiments | Sentiments analysis
[**ExtractDocumentsTokens**](OperationsApi.md#extractdocumentstokens) | **POST** /operations/tokens | Text parsing
[**ExtractEntities**](OperationsApi.md#extractentities) | **GET** /operations/entities | Entities extraction
[**ExtractFacts**](OperationsApi.md#extractfacts) | **GET** /operations/facts | Facts extraction
[**ExtractKeywords**](OperationsApi.md#extractkeywords) | **GET** /operations/keywords | Keywords extraction
[**ExtractSentiments**](OperationsApi.md#extractsentiments) | **GET** /operations/sentiments | Sentiments analysis
[**ExtractTokens**](OperationsApi.md#extracttokens) | **GET** /operations/tokens | Text parsing
[**GetDocumentsLanguages**](OperationsApi.md#getdocumentslanguages) | **POST** /operations/languages | Language detection
[**GetLanguages**](OperationsApi.md#getlanguages) | **GET** /operations/languages | Language detection


<a name="extractdocumentsentities"></a>
# **ExtractDocumentsEntities**
> EntitiesResponse ExtractDocumentsEntities (Documents documents, string positions = null)

Entities extraction

The operation extracts entities from each file.

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ExtractDocumentsEntitiesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var documents = new Documents(); // Documents | Documents to process
            var positions = "none"; // string | Positions format to be returned from server: - `none` - Don't return positions (**default**) - `symbol` - Symbol positions - `token` - Token positions  (optional) 

            try
            {
                // Entities extraction
                EntitiesResponse result = apiInstance.ExtractDocumentsEntities(documents, positions);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ExtractDocumentsEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documents** | [**Documents**](Documents.md)| Documents to process | 
 **positions** | **string**| Positions format to be returned from server: - &#x60;none&#x60; - Don&#39;t return positions (**default**) - &#x60;symbol&#x60; - Symbol positions - &#x60;token&#x60; - Token positions  | [optional] 

### Return type

[**EntitiesResponse**](EntitiesResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractdocumentsfacts"></a>
# **ExtractDocumentsFacts**
> FactsResponse ExtractDocumentsFacts (Documents documents, string positions = null)

Facts extraction

The operation extracts facts from each file. The term \"fact\" is used to denote phenomena, events, notions and relations between them which may be of interest to users.  

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ExtractDocumentsFactsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var documents = new Documents(); // Documents | Documents to process
            var positions = "none"; // string | Positions format to be returned from server: - `none` - Don't return positions (**default**) - `symbol` - Symbol positions - `token` - Token positions  (optional) 

            try
            {
                // Facts extraction
                FactsResponse result = apiInstance.ExtractDocumentsFacts(documents, positions);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ExtractDocumentsFacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documents** | [**Documents**](Documents.md)| Documents to process | 
 **positions** | **string**| Positions format to be returned from server: - &#x60;none&#x60; - Don&#39;t return positions (**default**) - &#x60;symbol&#x60; - Symbol positions - &#x60;token&#x60; - Token positions  | [optional] 

### Return type

[**FactsResponse**](FactsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractdocumentskeywords"></a>
# **ExtractDocumentsKeywords**
> KeywordsResponse ExtractDocumentsKeywords (Documents documents, string positions = null)

Keywords extraction

The operation explores often mentioned terms in each file. The response returns keywords and other statistics extracted from each file.

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ExtractDocumentsKeywordsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var documents = new Documents(); // Documents | Documents to process
            var positions = "none"; // string | Positions format to be returned from server: - `none` - Don't return positions (**default**) - `symbol` - Symbol positions - `token` - Token positions  (optional) 

            try
            {
                // Keywords extraction
                KeywordsResponse result = apiInstance.ExtractDocumentsKeywords(documents, positions);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ExtractDocumentsKeywords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documents** | [**Documents**](Documents.md)| Documents to process | 
 **positions** | **string**| Positions format to be returned from server: - &#x60;none&#x60; - Don&#39;t return positions (**default**) - &#x60;symbol&#x60; - Symbol positions - &#x60;token&#x60; - Token positions  | [optional] 

### Return type

[**KeywordsResponse**](KeywordsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractdocumentssentiments"></a>
# **ExtractDocumentsSentiments**
> SentimentsResponse ExtractDocumentsSentiments (Documents documents, string positions = null)

Sentiments analysis

The operation extracts opinions and emotions related to something, identifies the subject, the object of evaluation and the evaluation itself in each file.  

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ExtractDocumentsSentimentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var documents = new Documents(); // Documents | Documents to process
            var positions = "none"; // string | Positions format to be returned from server: - `none` - Don't return positions (**default**) - `symbol` - Symbol positions - `token` - Token positions  (optional) 

            try
            {
                // Sentiments analysis
                SentimentsResponse result = apiInstance.ExtractDocumentsSentiments(documents, positions);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ExtractDocumentsSentiments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documents** | [**Documents**](Documents.md)| Documents to process | 
 **positions** | **string**| Positions format to be returned from server: - &#x60;none&#x60; - Don&#39;t return positions (**default**) - &#x60;symbol&#x60; - Symbol positions - &#x60;token&#x60; - Token positions  | [optional] 

### Return type

[**SentimentsResponse**](SentimentsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractdocumentstokens"></a>
# **ExtractDocumentsTokens**
> TokensResponse ExtractDocumentsTokens (Documents documents)

Text parsing

Parse text in each file. The response returns the text which is divided into tokens and sentences, conducts morphological analysis, determines parts of speech, lemmas, etc. 

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ExtractDocumentsTokensExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var documents = new Documents(); // Documents | Documents to process

            try
            {
                // Text parsing
                TokensResponse result = apiInstance.ExtractDocumentsTokens(documents);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ExtractDocumentsTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documents** | [**Documents**](Documents.md)| Documents to process | 

### Return type

[**TokensResponse**](TokensResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractentities"></a>
# **ExtractEntities**
> EntitiesResponse ExtractEntities (string text, string positions = null)

Entities extraction

The operation extracts entities from the text document. For example, an entity may represent a person’s name, a name of an organization, an e-mail address, a phone number, or a geographical location.  

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ExtractEntitiesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var text = "Elvis Presley was born in Tupelo, Mississippi"; // string | Document text to process
            var positions = "none"; // string | Positions format to be returned from server: - `none` - Don't return positions (**default**) - `symbol` - Symbol positions - `token` - Token positions  (optional) 

            try
            {
                // Entities extraction
                EntitiesResponse result = apiInstance.ExtractEntities(text, positions);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ExtractEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Document text to process | 
 **positions** | **string**| Positions format to be returned from server: - &#x60;none&#x60; - Don&#39;t return positions (**default**) - &#x60;symbol&#x60; - Symbol positions - &#x60;token&#x60; - Token positions  | [optional] 

### Return type

[**EntitiesResponse**](EntitiesResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractfacts"></a>
# **ExtractFacts**
> FactsResponse ExtractFacts (string text, string positions = null)

Facts extraction

The operation extracts facts from the text. The term \"fact\" is used to denote phenomena, events, notions and relations between them which may be of interest to users.

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ExtractFactsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var text = "Elvis Presley was an American singer"; // string | Document text to process
            var positions = "none"; // string | Positions format to be returned from server: - `none` - Don't return positions (**default**) - `symbol` - Symbol positions - `token` - Token positions  (optional) 

            try
            {
                // Facts extraction
                FactsResponse result = apiInstance.ExtractFacts(text, positions);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ExtractFacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Document text to process | 
 **positions** | **string**| Positions format to be returned from server: - &#x60;none&#x60; - Don&#39;t return positions (**default**) - &#x60;symbol&#x60; - Symbol positions - &#x60;token&#x60; - Token positions  | [optional] 

### Return type

[**FactsResponse**](FactsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractkeywords"></a>
# **ExtractKeywords**
> KeywordsResponse ExtractKeywords (string text, string positions = null)

Keywords extraction

The operation explores often mentioned terms in the text. The response returns keywords and other statistics extracted from the text.

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ExtractKeywordsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var text = "The Senate Agriculture Committee was expected to consider proposals that would limit adjustments in county loan rate differentials which trigger larger corn and wheat acreage reduction requirements."; // string | Document text to process
            var positions = "none"; // string | Positions format to be returned from server: - `none` - Don't return positions (**default**) - `symbol` - Symbol positions - `token` - Token positions  (optional) 

            try
            {
                // Keywords extraction
                KeywordsResponse result = apiInstance.ExtractKeywords(text, positions);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ExtractKeywords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Document text to process | 
 **positions** | **string**| Positions format to be returned from server: - &#x60;none&#x60; - Don&#39;t return positions (**default**) - &#x60;symbol&#x60; - Symbol positions - &#x60;token&#x60; - Token positions  | [optional] 

### Return type

[**KeywordsResponse**](KeywordsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractsentiments"></a>
# **ExtractSentiments**
> SentimentsResponse ExtractSentiments (string text, string positions = null)

Sentiments analysis

Extract sentiments from document

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ExtractSentimentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var text = "The burger was great, but the waiter was very rude."; // string | Document text to process
            var positions = "none"; // string | Positions format to be returned from server: - `none` - Don't return positions (**default**) - `symbol` - Symbol positions - `token` - Token positions  (optional) 

            try
            {
                // Sentiments analysis
                SentimentsResponse result = apiInstance.ExtractSentiments(text, positions);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ExtractSentiments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Document text to process | 
 **positions** | **string**| Positions format to be returned from server: - &#x60;none&#x60; - Don&#39;t return positions (**default**) - &#x60;symbol&#x60; - Symbol positions - &#x60;token&#x60; - Token positions  | [optional] 

### Return type

[**SentimentsResponse**](SentimentsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extracttokens"></a>
# **ExtractTokens**
> TokensResponse ExtractTokens (string text)

Text parsing

Parse document text. The response returns the text which is divided into tokens and sentences, conducts morphological analysis, determines parts of speech, lemmas, etc. 

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ExtractTokensExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var text = "Elvis Presley was born in Tupelo, Mississippi"; // string | Document text to process

            try
            {
                // Text parsing
                TokensResponse result = apiInstance.ExtractTokens(text);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ExtractTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Document text to process | 

### Return type

[**TokensResponse**](TokensResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentslanguages"></a>
# **GetDocumentsLanguages**
> LanguagesResponse GetDocumentsLanguages (Documents documents)

Language detection

Automatically determine the language of each file.  The text encoding format of source files with the .txt extension must be strictly UTF-8. Otherwise, requests will not be executed. 

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class GetDocumentsLanguagesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var documents = new Documents(); // Documents | Documents to process

            try
            {
                // Language detection
                LanguagesResponse result = apiInstance.GetDocumentsLanguages(documents);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.GetDocumentsLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documents** | [**Documents**](Documents.md)| Documents to process | 

### Return type

[**LanguagesResponse**](LanguagesResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlanguages"></a>
# **GetLanguages**
> LanguagesResponse GetLanguages (string text)

Language detection

Detect the language of text documents

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class GetLanguagesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var text = "Elvis Presley was born in Tupelo, Mississippi"; // string | Document text to process

            try
            {
                // Language detection
                LanguagesResponse result = apiInstance.GetLanguages(text);
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.GetLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Document text to process | 

### Return type

[**LanguagesResponse**](LanguagesResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

