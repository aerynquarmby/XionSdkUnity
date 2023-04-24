
# Register Token Response

## Structure

`RegisterTokenResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | key for the accessing endpoint. |
| `JwtToken` | `string` | Optional | secret(JWT) for accessing endpoint should be kept safe. |

## Example (as JSON)

```json
{
  "clientId": "clientId6",
  "jwtToken": "jwtToken0"
}
```

