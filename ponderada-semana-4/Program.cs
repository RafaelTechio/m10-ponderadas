public class MetricTests
{
    [Fact]
    public void SaleIncrementsHatsSoldCounter()
    {
        // Arrange
        var services = CreateServiceProvider();
        var metrics = services.GetRequiredService<HatCoMetrics>();
        var meterFactory = services.GetRequiredService<IMeterFactory>();
        var collector = new MetricCollector<int>(meterFactory, "HatCo.Store", "hatco.store.hats_sold");

        // Act
        metrics.HatsSold(15);

        // Assert
        var measurements = collector.GetMeasurementSnapshot();
        Assert.Equal(1, measurements.Count);
        Assert.Equal(15, measurements[0].Value);
    }

    // Setup a new service provider. This example creates the collection explicitly but you might leverage
    // a host or some other application setup code to do this as well.
    private static IServiceProvider CreateServiceProvider()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddMetrics();
        serviceCollection.AddSingleton<HatCoMetrics>();
        return serviceCollection.BuildServiceProvider();
    }
}