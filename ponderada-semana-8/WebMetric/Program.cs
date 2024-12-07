using Prometheus;

var builder = WebApplication.CreateBuilder(args);

// Adicione serviços de métricas
builder.Services.AddMetrics();

var app = builder.Build();

// Use métricas do Prometheus
app.UseMetricServer(); // Adiciona endpoint padrão para Prometheus (/metrics)

app.MapGet("/", () => "Hello World!");

app.Run();
