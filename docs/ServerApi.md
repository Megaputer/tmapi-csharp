# TmApi.Api.ServerApi

All URIs are relative to *https://localhost:7008/tmapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangePassword**](ServerApi.md#changepassword) | **POST** /change-password | Change password
[**GetServerInfo**](ServerApi.md#getserverinfo) | **GET** /server | Server information


<a name="changepassword"></a>
# **ChangePassword**
> void ChangePassword (ChangePasswordRequest changePasswordRequest)

Change password

Use this request to change the password.

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var changePasswordRequest = new ChangePasswordRequest(); // ChangePasswordRequest | Change password request

            try
            {
                // Change password
                apiInstance.ChangePassword(changePasswordRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changePasswordRequest** | [**ChangePasswordRequest**](ChangePasswordRequest.md)| Change password request | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserverinfo"></a>
# **GetServerInfo**
> ServerInfo GetServerInfo ()

Server information

### Example
```csharp
using System;
using System.Diagnostics;
using TmApi.Api;
using TmApi.Client;
using TmApi.Model;

namespace Example
{
    public class GetServerInfoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();

            try
            {
                // Server information
                ServerInfo result = apiInstance.GetServerInfo();
                Debug.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetServerInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ServerInfo**](ServerInfo.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

