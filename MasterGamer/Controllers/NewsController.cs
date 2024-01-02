using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace MasterGamer.Controllers
{
    [AllowAnonymous]
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;
        private readonly UserManager<AppUser> _userManager;

        public NewsController(INewsService newsService, UserManager<AppUser> userManager)
        {
            _newsService = newsService;
            _userManager = userManager;
        }

        public IActionResult Index(int p = 1)
        {
            var values = _newsService.TGetList().ToPagedList(p, 5);
            return View(values);
        }

        public IActionResult NewsDetails(int id)
        {
            var values = _newsService.TGetNewsWithWriter(id);
            return View(values);
        }
    }
}
