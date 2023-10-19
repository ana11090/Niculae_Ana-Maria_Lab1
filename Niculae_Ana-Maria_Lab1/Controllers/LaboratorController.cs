using Microsoft.AspNetCore.Mvc;

namespace Niculae_Ana_Maria_Lab1.Controllers
{
    public class LaboratorController : Controller
    { 

        public IActionResult Index()
        {
            string mesajBunVenit = "Bine ați venit!"; // Mesajul de bun venit pe care dorești să-l afișezi
            return Content(mesajBunVenit);
        }

        public IActionResult Salut()
        {
            string salut = "Salut!";
            return Content(salut);
        }

        public IActionResult Mesaj(string nume, int varsta)
        {
            string mesaj = $"Numele meu este {nume} si am {varsta} de anii";
            return Content(mesaj);
        }
    }
}
