[![](https://img.shields.io/nuget/v/soenneker.quo.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quo.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quo.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quo.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quo.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quo.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quo.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.quo.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Quo.OpenApiClient

Generated request builders and models for Quo contacts, calls, messages, conversations, phone numbers, users, and webhooks.

## Installation

```bash
dotnet add package Soenneker.Quo.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Quo.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("Authorization", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://api.openphone.com"
};

var client = new QuoOpenApiClient(adapter);
var users = await client.V1.Users.GetAsync(
    cancellationToken: cancellationToken);
```

Quo, formerly OpenPhone, continues to expose the API from `api.openphone.com`. Send the API key directly in `Authorization`; Quo does not use the `Bearer` scheme for API keys. Set `BaseUrl` explicitly because the host embedded in the generated schema does not match the currently documented production endpoint.
