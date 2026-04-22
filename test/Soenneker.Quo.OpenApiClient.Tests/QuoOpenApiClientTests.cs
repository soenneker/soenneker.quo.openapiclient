using Soenneker.Tests.HostedUnit;

namespace Soenneker.Quo.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class QuoOpenApiClientTests : HostedUnitTest
{
    public QuoOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
