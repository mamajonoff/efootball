using efootball.Models;
using efootball.Services;
using efootball.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace efootball.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsInterface newsInterface;

        public HomeController(INewsInterface newsInterface)
        {
            this.newsInterface = newsInterface;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult News()
        {
            IndexViewModel viewModel = new()
            {
                News = newsInterface.GetNews()
            };

            return View(viewModel);
        }

        public IActionResult Price()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Detail(Guid id)
        {
            var news = newsInterface.GetNewsById(id);
            return View(news);
        }
    }
}