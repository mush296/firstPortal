
# Item

## Structure

`Item`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | `string` | Required | - |
| `Etag` | `string` | Required | - |
| `Id` | [`Models.Id`](../../doc/models/id.md) | Required | - |
| `Snippet` | [`Models.Snippet`](../../doc/models/snippet.md) | Required | - |

## Example (as JSON)

```json
{
  "kind": "youtube#searchResult",
  "etag": "42sWsNXP6je43LEZMKmEhWWAoGU",
  "id": {
    "kind": "youtube#video",
    "videoId": "7S5zT9RbO-o"
  },
  "snippet": {
    "publishedAt": "2022-08-10T11:31:41Z",
    "channelId": "UCCOuS3wCTlfU7udq2AytuLA",
    "title": "Getting Started with APIMatic in Under 3 Minutes",
    "description": "Learn how to create SDKs and API Developer Portal from your API specification file in just 3 minutes. 0:00 Introduction 0:27 Step ...",
    "thumbnails": {
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
    },
    "channelTitle": "APIMatic Official",
    "liveBroadcastContent": "none",
    "publishTime": "2022-08-10T11:31:41Z"
  }
}
```

