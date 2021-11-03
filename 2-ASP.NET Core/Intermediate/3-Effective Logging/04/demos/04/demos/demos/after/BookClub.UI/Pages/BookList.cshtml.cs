using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BookClub.Logic.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using BookClub.Infrastructure;
using BookClub.Infrastructure.BaseClasses;

namespace BookClub.UI.Pages
{
    public class BookListModel : BasePageModel
    {
        private readonly ILogger _logger;        
        public List<BookModel> Books;
        //private readonly Stopwatch _timer;

        public BookListModel(ILogger<BookListModel> logger) : base(logger)
        {
            _logger = logger;
            //_timer = new Stopwatch();
        }

        public async Task OnGetAsync()
        {
            var userId = User.Claims.FirstOrDefault(a => a.Type == "sub")?.Value;
            _logger.LogInformation("UI ENTRY: {UserName} - ({UserId}) is about to call the book api " +
                "to get all books. {Claims}", User.Identity.Name, userId, User.Claims);

            using (var http = new HttpClient(new StandardHttpMessageHandler(HttpContext, _logger)))
            {
                Books = (await http.GetFromJsonAsync<List<BookModel>>("https://localhost:44322/api/Book"))
                    .OrderByDescending(a => a.Id).ToList();
            }
        }

        //public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        //{
        //    _timer.Start();
        //}

        //public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        //{
        //    _timer.Stop();
        //    _logger.LogRoutePerformance(context.ActionDescriptor.RelativePath,
        //        context.HttpContext.Request.Method,
        //        _timer.ElapsedMilliseconds);
        //}
    }
}