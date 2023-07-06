using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using MyDrawingJourney.ViewModels.Home;

namespace MyDrawingJourney.Controllers
{
    public class ContactController : Controller
    {
        private readonly IEmailSender _emailSender;

        public ContactController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpGet]
        public IActionResult ContactMail()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ContactMail(ContactViewModel contact)
        {
            var msg = contact.Name + " " + contact.Message;
            await _emailSender.SendEmailAsync(contact.Email, "Contact Mail", msg);
            ViewBag.ConfirmMsg = "Thanks for your Mail!";
            return View();
        }
    }
}
