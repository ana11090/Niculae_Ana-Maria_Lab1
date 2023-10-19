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

        public IActionResult SalutUtilizator()
        {
            string salut = "Salut!";
            return Content(salut);
        }

        public IActionResult MesajCuParametri(string text, int numar)
        {
            string mesaj = $"Textul introdus este: {text}, iar numărul este: {numar}";
            return Content(mesaj);
        }
    }
}
