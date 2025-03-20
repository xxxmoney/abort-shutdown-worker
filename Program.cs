using AbortShutdownWorker;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddWindowsService(options =>
{
    options.ServiceName = ".NET Joke Service";
});

var host = builder.Build();
host.Run();