using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeHasVisto.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display()
        {
            
            var name = (string)RouteData.Values["id"];
            object model = null;
            if (model == null)
            return RedirectToAction("NotFound");
            return View(); // View(model);

           
        }
        public ActionResult NotFound()
        {
            ViewBag.ErrorCode = "NFE00001";
            ViewBag.Description = "La mascota no se encuentra" +
                "en la base de datos";
            return View();

           // ViewData["ErrorCode"] = "NFE0001";
            //ViewData["Description"] = "La masocota no se encuentra" +
               // "en la base de datos";
            //return View();
        }

        public FileResult DownLoadPicture()
        {
            //Descargar cierta imagen nos retorna en unservidor
            var name = (string)RouteData.Values["id"];
            var picture = @"C:\Users\Linet\Pictures/" + name + ".jpg";
            //var picture = "/Content/Uploads/" + name + ".jpg";
            var contentType = "image/jpg";
            var fileName = name + ".jpg";
            return File(picture, contentType, fileName);
        }

        public HttpStatusCodeResult UnauthorizedError()
        {
            return new HttpUnauthorizedResult("Error de acceso no aturizado");
        }

        public ActionResult NotFoundError()
        {
            return HttpNotFound("Nada por aqui....");
        }

        //Action Mathod que permite la carga 
        //de la foto de ua mascota
        public ActionResult PictureUpload()
        {
            return View();
        }
    }
}
