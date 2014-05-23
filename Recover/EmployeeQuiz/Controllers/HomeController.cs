using EmployeeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            //creo el objeto
            //del modelo de datos
            PayrollDm nomina = new PayrollDm(
                @"C:\Users\Linet\documents\visual studio 2012\Projects\Recover\EmployeeQuiz\Models\Bd_Empleados.csv");

            //Busco el empleado dado su ID
            var empleado = nomina.GetEmployeeById(emp.Id);
            if (ModelState.IsValid)
            {

                return View("WorkerView", empleado);
            }
            else 
            {
                return View();
            }
        }

    }
}
