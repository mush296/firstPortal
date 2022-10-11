# API

```csharp
APIController aPIController = client.APIController;
```

## Class Name

`APIController`


# You Tube Search

```csharp
YouTubeSearchAsync(
    string part,
    string q,
    string type)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `part` | `string` | Query, Required | - |
| `q` | `string` | Query, Required | Name of the video the user would like to search for. |
| `type` | `string` | Query, Required | - |

## Response Type

[`Task<Models.YTSearchResult>`](../../doc/models/yt-search-result.md)

## Example Usage

```csharp
string part = "snippet";
string q = "apimatic";
string type = "video";

try
{
    YTSearchResult result = await aPIController.YouTubeSearchAsync(part, q, type);
}
catch (ApiException e){};
```

