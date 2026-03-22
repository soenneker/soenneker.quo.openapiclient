using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quo.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class QuoOpenApiClientTests : FixturedUnitTest
{
    public QuoOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
