# API

```csharp
IAPIController aPIController = client.APIController;
```

## Class Name

`APIController`

## Methods

* [Delete Client App](../../doc/controllers/api.md#delete-client-app)
* [Get Client Ids](../../doc/controllers/api.md#get-client-ids)
* [Get Order Status](../../doc/controllers/api.md#get-order-status)
* [Health](../../doc/controllers/api.md#health)
* [Register](../../doc/controllers/api.md#register)
* [Single Bill Payment](../../doc/controllers/api.md#single-bill-payment)


# Delete Client App

This endpoint is use to delete a registered client app.

```csharp
DeleteClientAppAsync(
    string merchantWalletAddress,
    string clientId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantWalletAddress` | `string` | Template, Required | - |
| `clientId` | `string` | Template, Required | - |

## Response Type

`Task<string>`

## Example Usage

```csharp
string merchantWalletAddress = "merchantWalletAddress6";
string clientId = "clientId6";
try
{
    string result = await aPIController.DeleteClientAppAsync(merchantWalletAddress, clientId);
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


# Get Client Ids

This endpoint is use to get a list of client Ids created by the merchant.

```csharp
GetClientIdsAsync(
    string merchantWalletAddress)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantWalletAddress` | `string` | Template, Required | - |

## Response Type

[`Task<Models.ListClientAppsResponse>`](../../doc/models/list-client-apps-response.md)

## Example Usage

```csharp
string merchantWalletAddress = "merchantWalletAddress6";
try
{
    ListClientAppsResponse result = await aPIController.GetClientIdsAsync(merchantWalletAddress);
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


# Get Order Status

This endpoint is use to get the status of an order.

```csharp
GetOrderStatusAsync(
    string orderCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderCode` | `string` | Template, Required | - |

## Response Type

`Task<string>`

## Example Usage

```csharp
string orderCode = "orderCode8";
try
{
    string result = await aPIController.GetOrderStatusAsync(orderCode);
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


# Health

This endpoint is use to check the health of the API.

:information_source: **Note** This endpoint does not require authentication.

```csharp
HealthAsync()
```

## Response Type

`Task<string>`

## Example Usage

```csharp
try
{
    string result = await aPIController.HealthAsync();
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
| 500 | Internal Server Error | `ApiException` |


# Register

This endpoint is use to register a new client access.

:information_source: **Note** This endpoint does not require authentication.

```csharp
RegisterAsync(
    Models.RegisterTokenRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.RegisterTokenRequest`](../../doc/models/register-token-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.RegisterTokenResponse>`](../../doc/models/register-token-response.md)

## Example Usage

```csharp
try
{
    RegisterTokenResponse result = await aPIController.RegisterAsync(null);
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


# Single Bill Payment

This endpoint is use to make a single bill payment.

```csharp
SingleBillPaymentAsync(
    Models.SingleBillPaymentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.SingleBillPaymentRequest`](../../doc/models/single-bill-payment-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.SingleBillPaymentResponse>`](../../doc/models/single-bill-payment-response.md)

## Example Usage

```csharp
try
{
    SingleBillPaymentResponse result = await aPIController.SingleBillPaymentAsync(null);
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
| 401 | Unauthorized | `ApiException` |
| 500 | Internal Server Error | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |

