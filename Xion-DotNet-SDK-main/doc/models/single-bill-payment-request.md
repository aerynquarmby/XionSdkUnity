
# Single Bill Payment Request

## Structure

`SingleBillPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductName` | `string` | Optional | Name of the product. |
| `Amount` | `double?` | Optional | Amount to be paid (USD). |
| `Currency` | `string` | Optional | Currency of the amount to paid. |
| `BuyerAddress` | `string` | Optional | Buyer's wallet address. |

## Example (as JSON)

```json
{
  "productName": "productName0",
  "amount": 56.78,
  "currency": "currency0",
  "buyerAddress": "buyerAddress8"
}
```

