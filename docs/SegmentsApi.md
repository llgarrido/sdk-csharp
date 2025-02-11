# org.egoi.client.api.Api.SegmentsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSegment**](SegmentsApi.md#deletesegment) | **DELETE** /lists/{list_id}/segments/{segment_id} | Remove segment
[**GetAllSegments**](SegmentsApi.md#getallsegments) | **GET** /lists/{list_id}/segments | Get all segments



## DeleteSegment

> void DeleteSegment (string segmentId, int listId)

Remove segment

Remove segment information given its ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteSegmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SegmentsApi(Configuration.Default);
            var segmentId = segmentId_example;  // string | ID of the Segment
            var listId = 56;  // int | ID of the List

            try
            {
                // Remove segment
                apiInstance.DeleteSegment(segmentId, listId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SegmentsApi.DeleteSegment: " + e.Message );
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
 **segmentId** | **string**| ID of the Segment | 
 **listId** | **int**| ID of the List | 

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


## GetAllSegments

> SegmentCollection GetAllSegments (int listId, string type = null, string name = null, int? offset = null, int? limit = null)

Get all segments

Returns all segments

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllSegmentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SegmentsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var type = type_example;  // string | Type of segment (optional) 
            var name = name_example;  // string | Segment name (optional) 
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)

            try
            {
                // Get all segments
                SegmentCollection result = apiInstance.GetAllSegments(listId, type, name, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SegmentsApi.GetAllSegments: " + e.Message );
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
 **type** | **string**| Type of segment | [optional] 
 **name** | **string**| Segment name | [optional] 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]

### Return type

[**SegmentCollection**](SegmentCollection.md)

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

