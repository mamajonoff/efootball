using efootball.Models;
using efootball.Services;
using efootball.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace efootball.Controllers
{
    public class AdminController : Controller
    {
        private readonly INewsInterface newsInterface;
        private readonly ImageInterface imageInterface;

        public AdminController(INewsInterface newsInterface,
                               ImageInterface imageInterface)
        {
            this.newsInterface = newsInterface;
            this.imageInterface = imageInterface;
        }

        public IActionResult Index()
        {
            var news = newsInterface.GetNews();
            return View(news);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddNewsViewModel viewModel)
        {
            News news = new()
            {
                Id = Guid.NewGuid(),
                Title = viewModel.Title,
                Body = viewModel.Body,
                Images = imageInterface.SaveImage(viewModel.Image)
            };
            newsInterface.AddNews(news);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            var news = newsInterface.GetNewsById(id);
            imageInterface.DeleteImage(news.Images);
            newsInterface.DeleteNews(id);

            return RedirectToAction("Index");
        }
    }
}
