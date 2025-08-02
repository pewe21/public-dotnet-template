
namespace learnjwt.Service;
public interface IBookService
{
    public Task UploadFileImage(IFormFile file, string bookId);
    
}