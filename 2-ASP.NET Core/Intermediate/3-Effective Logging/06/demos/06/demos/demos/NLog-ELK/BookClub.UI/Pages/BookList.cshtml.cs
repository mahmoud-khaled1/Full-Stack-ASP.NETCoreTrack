using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BookClub.Logic.Models;
using Microsoft.Extensions.Logging;
using BookClub.Infrastructure;
using BookClub.Infrastructure.BaseClasses;

namespace BookClub.UI.Pages
{
    public class BookListModel : BasePageModel
    {
        private readonly ILogger _logger;        
        public List<BookModel> Books;

        public BookListModel(ILogger<BookListModel> logger, IScopeInformation scope) : base(logger, scope)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {            
            using (var http = new HttpClient(new StandardHttpMessageHandler(HttpContext, _logger)))
            {
                Books = (await http.GetFromJsonAsync<List<BookModel>>("https://localhost:44322/api/Book"))
                    .OrderByDescending(a => a.Id).ToList();
            }
        }       
    }
}