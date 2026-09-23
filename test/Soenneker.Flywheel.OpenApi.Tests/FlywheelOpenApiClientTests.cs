using Soenneker.Tests.HostedUnit;

namespace Soenneker.Flywheel.OpenApi.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class FlywheelOpenApiClientTests : HostedUnitTest
{
    public FlywheelOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
