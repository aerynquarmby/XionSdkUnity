
# List Client Apps Response

## Structure

`ListClientAppsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantWalletAddress` | `string` | Optional | Wallet address of merchant. |
| `ClientIds` | [`List<Models.ClientId>`](../../doc/models/client-id.md) | Optional | List of client Ids created by the merchant. |

## Example (as JSON)

```json
{
  "merchantWalletAddress": "merchantWalletAddress6",
  "clientIds": [
    {
      "clientId": "clientId3",
      "name": "name9",
      "createdAt": "2016-03-13T12:52:32.123Z"
    },
    {
      "clientId": "clientId4",
      "name": "name0",
      "createdAt": "2016-03-13T12:52:32.123Z"
    },
    {
      "clientId": "clientId5",
      "name": "name1",
      "createdAt": "2016-03-13T12:52:32.123Z"
    }
  ]
}
```

