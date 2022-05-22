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
    private readonly IDocumentRepository _documentRepository;

    public BookService(IDocumentRepository documentRepository, ILogger<BookService> logger)
    {
      _documentRepository = documentRepository;
    }

    public Book GetBookById(string id)
    {
      return null;
    }
  }
}