# org.egoi.client.api.Api.EcommerceActivityApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImportOrdersBulk**](EcommerceActivityApi.md#importordersbulk) | **POST** /lists/{list_id}/orders | Orders import bulk request



## ImportOrdersBulk

> AcceptedResponse ImportOrdersBulk (int listId, List<ImportOrdersBulkBulkRequest> importOrdersBulkBulkRequest)

Orders import bulk request

Creates new bulk orders syncronization </br>      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits 'Stream Limits')

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ImportOrdersBulkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceActivityApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var importOrdersBulkBulkRequest = new List<ImportOrdersBulkBulkRequest>(); // List<ImportOrdersBulkBulkRequest> | Parameters for the Orders

            try
            {
                // Orders import bulk request
                AcceptedResponse result = apiInstance.ImportOrdersBulk(listId, importOrdersBulkBulkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceActivityApi.ImportOrdersBulk: " + e.Message );
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
 **listId** | **int**| ID of the List | 
 **importOrdersBulkBulkRequest** | [**List&lt;ImportOrdersBulkBulkRequest&gt;**](ImportOrdersBulkBulkRequest.md)| Parameters for the Orders | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

