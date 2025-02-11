# org.egoi.client.api.Api.UsersApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{user_id} | Remove user
[**GetAllUsers**](UsersApi.md#getallusers) | **GET** /users | Get all users



## DeleteUser

> void DeleteUser (int userId)

Remove user

Remove user information given its ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var userId = 56;  // int | ID of the User

            try
            {
                // Remove user
                apiInstance.DeleteUser(userId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int**| ID of the User | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **408** | Request Timeout |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllUsers

> UserCollection GetAllUsers (string username = null, string status = null, DateTime? createdMin = null, DateTime? createdMax = null, DateTime? updatedMin = null, DateTime? updatedMax = null, int? offset = null, int? limit = null, string order = null, string orderBy = null)

Get all users

Returns all users

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var username = username_example;  // string | Reference attribute to username user (optional) 
            var status = status_example;  // string | Status filter (optional) 
            var createdMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Created initial date (optional) 
            var createdMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Created finish (optional) 
            var updatedMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Updated initial (optional) 
            var updatedMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Updated finish (optional) 
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var order = order_example;  // string | Type of order (optional)  (default to desc)
            var orderBy = orderBy_example;  // string | Reference attribute to order users (optional)  (default to user_id)

            try
            {
                // Get all users
                UserCollection result = apiInstance.GetAllUsers(username, status, createdMin, createdMax, updatedMin, updatedMax, offset, limit, order, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.GetAllUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Reference attribute to username user | [optional] 
 **status** | **string**| Status filter | [optional] 
 **createdMin** | **DateTime?**| Created initial date | [optional] 
 **createdMax** | **DateTime?**| Created finish | [optional] 
 **updatedMin** | **DateTime?**| Updated initial | [optional] 
 **updatedMax** | **DateTime?**| Updated finish | [optional] 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **order** | **string**| Type of order | [optional] [default to desc]
 **orderBy** | **string**| Reference attribute to order users | [optional] [default to user_id]

### Return type

[**UserCollection**](UserCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

