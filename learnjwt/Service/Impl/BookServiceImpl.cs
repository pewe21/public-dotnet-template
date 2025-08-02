using learnjwt.AppContext;
using learnjwt.Service;


namespace learnjwt.Service.Impl;
public class BookServiceImpl : IBookService
{

    private readonly MyDbContext _context;

    public BookServiceImpl(MyDbContext context)
    {
        _context = context;
    }

    public async Task UploadFileImage(IFormFile file, string bookId)
    {
        var book = await _context.Books.FindAsync(bookId);
        if (book == null)
        {
            throw new Exception("Book not found");
        }

        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        var filePath = Path.Combine("wwwroot/images", fileName);
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        book.Image = fileName;
        await _context.SaveChangesAsync();
    }

}