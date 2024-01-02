using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MasterGamer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public IActionResult Index()
        {
            var values = _newsService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNews()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNews(News news)
        {
            _newsService.TAdd(news);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteNews(int id)
        {
            var values = _newsService.TGetByID(id);
            _newsService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateNews(int id)
        {
            var values = _newsService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateNews(News news)
        {
            _newsService.TUpdate(news);
            return RedirectToAction("Index");
        }
    }
}
