using BookStop.Worker;
using BookStop.Worker.Repositories;
using BookStop.Worker.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
      services.AddTransient<IDocumentRepository, DocumentRepository>();
      services.AddTransient<IBookService, BookService>();
      services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
