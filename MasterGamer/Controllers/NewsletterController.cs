using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using MasterGamer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MasterGamer.Controllers
{
    [AllowAnonymous]
    public class NewsletterController : Controller
    {
        private readonly ISubscribeService _subscribeService;

        public NewsletterController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult Subscribe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Subscribe(NewsletterSubscribeModel subscribeModel)
        {
            if (ModelState.IsValid)
            {
                bool result = _subscribeService.SubscribeToNewsletter(subscribeModel.Email);
                if (result)
                {
                    TempData["SuccessMessage"] = "Başarıyla e-posta bültenimize kayıt oldunuz!";
                }
                else
                {
                    TempData["ErrorMessage"] = "Bu e-posta zaten kayıtlı!";
                }
                return RedirectToAction("Index", "Default");
            }
            return View(subscribeModel);
        }
    }
}
