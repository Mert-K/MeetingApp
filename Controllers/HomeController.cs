using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewData["Selamlama"] = saat > 12 ? "İyi günler" : "Günaydın";
            //ViewData["Username"] = "Çınar";

            MeetingInfo meetinginfo = new()
            {
                Id = 1,
                Location = "İstanbul, Abc Kongre Merkezi",
                Date = new DateTime(year: 2024, month: 01, day: 20, hour: 20, minute: 00, second: 00),
                NumberOfPeople = Repository.Users.Where(u => u.WillAttend == true).Count()
            };

            return View(model:meetinginfo);
        }
    }
}
