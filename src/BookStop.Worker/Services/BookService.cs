using Bookstop.Worker.Models;
using BookStop.Worker.Repositories;

namespace BookStop.Worker.Services
{
  public interface IBookService
  {
    Book GetBookById(string id);
  }

  public class BookService : IBookService
  {
    public BookService(IDocumentRepository documentRepository, ILogger<BookService> logger)
    {

    }

    public Book GetBookById(string id)
    {
      throw new NotImplementedException();
    }
  }
}