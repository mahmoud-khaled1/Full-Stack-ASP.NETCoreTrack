using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PieShop.ViewModels;
namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly ILogger<PieController> _logger;
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(ILogger<PieController> logger,IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _logger = logger;
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;

        }

        public IActionResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.Pies = _pieRepository.AllPie;
            pieListViewModel.CurrentCategory = "Cheese Cakes";
            return View(pieListViewModel);

            //return View(_pieRepository.AllPie);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
