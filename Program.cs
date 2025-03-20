using AbortShutdownWorker;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddWindowsService(options =>
{
    options.ServiceName = "Abort Shutdown Worker";
});

var host = builder.Build();
host.Run();