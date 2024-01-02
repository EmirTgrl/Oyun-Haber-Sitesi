using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace MasterGamer.Controllers
{
    [AllowAnonymous]
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;
        private readonly UserManager<AppUser> _userManager;

        public ReviewController(IReviewService reviewService, UserManager<AppUser> userManager)
        {
            _reviewService = reviewService;
            _userManager = userManager;
        }

        public IActionResult Index(int p = 1)
        {
            var values = _reviewService.TGetList().ToPagedList(p, 5);
            return View(values);
        }

        public IActionResult ReviewDetails(int id)
        {
            var values = _reviewService.TGetReviewWithWriter(id);
            return View(values);
        }
    }
}
