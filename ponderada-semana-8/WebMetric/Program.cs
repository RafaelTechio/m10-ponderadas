using Prometheus;

var builder = WebApplication.CreateBuilder(args);

// Adicione serviços de métricas
builder.Services.AddMetrics();

var app = builder.Build();
app.Urls.Add("http://*:5190");
app.UseMetricServer();
app.MapGet("/", () => "Hello World!");
app.Run();

