
# Snippet

## Structure

`Snippet`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PublishedAt` | `string` | Required | - |
| `ChannelId` | `string` | Required | - |
| `Title` | `string` | Required | - |
| `Description` | `string` | Required | - |
| `Thumbnails` | [`Models.Thumbnails`](../../doc/models/thumbnails.md) | Required | - |
| `ChannelTitle` | `string` | Required | - |
| `LiveBroadcastContent` | `string` | Required | - |
| `PublishTime` | `string` | Required | - |

## Example (as JSON)

```json
{
  "publishedAt": "08/10/2022 11:31:41",
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
  "publishTime": "08/10/2022 11:31:41"
}
```

