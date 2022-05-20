using BookStop.Worker.Services;

namespace BookStop.Worker;

public class Worker : BackgroundService
{
  private readonly IBookService _firestoreService;
  private readonly ILogger<Worker> _logger;

  public Worker(IBookService firestoreService, ILogger<Worker> logger)
  {
    _firestoreService = firestoreService;
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
