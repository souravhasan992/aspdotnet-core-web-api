using AspDotNetCoreWebApi.Data.Services;
using AspDotNetCoreWebApi.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService = booksService;   
        }
        [HttpPost]
        public IActionResult AddBook([FromBody] VmBook book)
        {
            _booksService.AddBook(book);
            return Ok();
        }
    }
}
