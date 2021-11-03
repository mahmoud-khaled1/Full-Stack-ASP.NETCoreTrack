using BookClub.Infrastructure.BaseClasses;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BookClub.UI.Pages
{
    public class AboutModel : BasePageModel
    {
        public AboutModel(ILogger<AboutModel> logger) : base(logger)
        {

        }
        public void OnGet()
        {
            //throw new Exception("Users should not see this!");
        }
    }
}