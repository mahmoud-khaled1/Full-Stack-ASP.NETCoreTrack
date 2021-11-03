using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BookClub.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BookClub.UI.Pages
{
    public class BookListModel : PageModel
    {
        private readonly ILogger _logger;
        public List<Book> Books;

        public BookListModel(ILogger<BookListModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            _logger.LogInformation("About to call API to get book list");
            using (var http = new HttpClient(new StandardHttpMessageHandler(HttpContext)))
            {
                Books = await http.GetFromJsonAsync<List<Book>>("https://localhost:44322/api/Book");
            }
        }
    }
}