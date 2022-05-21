using BookStop.Worker.Services;

namespace BookStop.Worker;

public class Worker : BackgroundService
{
  private readonly IBookService _bookService;
  private readonly ILogger<Worker> _logger;

  public Worker(IBookService bookService, ILogger<Worker> logger)
  {
    _bookService = bookService;
    _logger = logger;
  }

  protected override async Task ExecuteAsync(CancellationToken stoppingToken)
  {
    while (!stoppingToken.IsCancellationRequested)
    {
      _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
      await Task.Delay(1000, stoppingToken);
    }
  }
}
