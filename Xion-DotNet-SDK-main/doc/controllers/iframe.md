# Iframe

```csharp
IIframeController iframeController = client.IframeController;
```

## Class Name

`IframeController`

## Methods

* [Create Iframe Products](../../doc/controllers/iframe.md#create-iframe-products)
* [Get Iframe Product by Code](../../doc/controllers/iframe.md#get-iframe-product-by-code)
* [Get Iframe Products](../../doc/controllers/iframe.md#get-iframe-products)
* [Update Iframe Products](../../doc/controllers/iframe.md#update-iframe-products)


# Create Iframe Products

This endpoint is used to create iframe products.

```csharp
CreateIframeProductsAsync(
    List<Models.IframeProductsRequest> body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`List<Models.IframeProductsRequest>`](../../doc/models/iframe-products-request.md) | Body, Optional | - |

## Response Type

[`Task<List<Models.IframeProductsResponse>>`](../../doc/models/iframe-products-response.md)

## Example Usage

```csharp
try
{
    List<IframeProductsResponse> result = await iframeController.CreateIframeProductsAsync(null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |
| 500 | Internal Server Error | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |


# Get Iframe Product by Code

This endpoint is used to get product by code.

```csharp
GetIframeProductByCodeAsync(
    string referenceId,
    string name = null,
    int? price = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `referenceId` | `string` | Template, Required | - |
| `name` | `string` | Query, Optional | Name of product |
| `price` | `int?` | Query, Optional | - |

## Response Type

[`Task<Models.IframeProductResponse>`](../../doc/models/iframe-product-response.md)

## Example Usage

```csharp
string referenceId = "referenceId8";
try
{
    IframeProductResponse result = await iframeController.GetIframeProductByCodeAsync(referenceId, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |
| 500 | Internal Server Error | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |


# Get Iframe Products

This endpoint is used to get iframe products.

```csharp
GetIframeProductsAsync()
```

## Response Type

[`Task<List<Models.IframeProductsResponse>>`](../../doc/models/iframe-products-response.md)

## Example Usage

```csharp
try
{
    List<IframeProductsResponse> result = await iframeController.GetIframeProductsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |
| 500 | Internal Server Error | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |


# Update Iframe Products

This endpoint is used to get product.

```csharp
UpdateIframeProductsAsync(
    List<Models.IframeProductsRequest> body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`List<Models.IframeProductsRequest>`](../../doc/models/iframe-products-request.md) | Body, Optional | - |

## Response Type

[`Task<List<Models.IframeProductsResponse>>`](../../doc/models/iframe-products-response.md)

## Example Usage

```csharp
try
{
    List<IframeProductsResponse> result = await iframeController.UpdateIframeProductsAsync(null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |
| 500 | Internal Server Error | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |

