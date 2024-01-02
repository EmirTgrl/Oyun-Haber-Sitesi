using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace MasterGamer.ViewComponents.Default
{
    public class _News : ViewComponent
    {
        private readonly INewsService _newsService;

        public _News(INewsService newsService)
        {
            _newsService = newsService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _newsService.TGetLast4News();
            return View(values);
        }
    }
}
