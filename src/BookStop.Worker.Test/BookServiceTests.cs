using BookStop.Worker.Services;
using BookStop.Worker.Repositories;
using Microsoft.Extensions.Logging;

namespace BookStop.Worker.Test;

public class BookServiceTests
{
  [Fact]
  public void GetBookById_DocumentNotFound_Returns_Default()
  {
    var mockLogger = new Mock<ILogger<BookService>>();
    var mockDocumentRepository = new Mock<IDocumentRepository>();
    
    var bookService = new BookService(mockDocumentRepository.Object, mockLogger.Object);

    var result = bookService.GetBookById("abc");

    Assert.Null(result);
  }
}