using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MasterGamer.ViewComponents.Default
{
    public class _Reviews : ViewComponent
    {
        private readonly IReviewService _reviewService;

        public _Reviews(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _reviewService.TGetLast3Reviews();
            return View(values);
        }
    }
}
