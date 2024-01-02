using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MasterGamer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        public IActionResult Index()
        {
            var values = _reviewService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddReview()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReview(Review review)
        {
            _reviewService.TAdd(review);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteReview(int id)
        {
            var values = _reviewService.TGetByID(id);
            _reviewService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateReview(int id)
        {
            var values = _reviewService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateReview(Review review)
        {
            _reviewService.TUpdate(review);
            return RedirectToAction("Index");
        }
    }
}
