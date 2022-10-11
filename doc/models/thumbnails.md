
# Thumbnails

## Structure

`Thumbnails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Default` | [`Models.Default`](../../doc/models/default.md) | Required | - |
| `Medium` | [`Models.Medium`](../../doc/models/medium.md) | Required | - |
| `High` | [`Models.High`](../../doc/models/high.md) | Required | - |

## Example (as JSON)

```json
{
  "default": {
    "url": "https://i.ytimg.com/vi/7S5zT9RbO-o/default.jpg",
    "width": 120,
    "height": 90
  },
  "medium": {
    "url": "https://i.ytimg.com/vi/7S5zT9RbO-o/mqdefault.jpg",
    "width": 320,
    "height": 180
  },
  "high": {
    "url": "https://i.ytimg.com/vi/7S5zT9RbO-o/hqdefault.jpg",
    "width": 480,
    "height": 360
  }
}
```

