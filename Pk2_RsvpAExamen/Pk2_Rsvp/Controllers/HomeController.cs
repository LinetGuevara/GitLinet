using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pk2_Rsvp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Buenos dias Itgam!!" : "Buenas Tardes";
            return View();
        }

        
        //Get: /Home/RsvpFrom
        //Renderea el link de la from del RSVP
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        //Responde a un POST: /Home/RsvpForm
        [HttpPost]
        public ViewResult RsvpForm(Pk2_Rsvp.Models.GuestResponse guestResponse) 
        {
            //Verificando  errores de validacion
            if (ModelState.IsValid)
            {
                //Todo: Enviar respuesta al correo del organizador
                return View("Agradecimientos", guestResponse);
            }
            else
            { 
                //Hay un problema de validacion
                return View();
            }
        }

    }
}
