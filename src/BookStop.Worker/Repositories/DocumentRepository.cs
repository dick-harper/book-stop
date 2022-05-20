using Bookstop.Worker.Models;

namespace BookStop.Worker.Repositories
{
  public interface IDocumentRepository
  {
    Document GetById(string id);
  }

  public class DocumentRepository : IDocumentRepository
  {
    public Document GetById(string id)
    {
      Document document = new Document
      {
        Id = string.Empty
      };

      return document;
    }
  }
}