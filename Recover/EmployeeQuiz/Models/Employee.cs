using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EmployeeQuiz.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Introduce tu ID:")]
        public string Id{ get; set; }//Representa las propiedades de un Empleado 

        public string Name { get; set; }//Modela a una persona
        public string FirstLastname { get; set; }
        public string SecondLastname { get; set; }
        public string Position { get; set; }
        public double Wage { get; set; }
        public char Sex{ get; set; }
        public string PhotoPath { get; set; }
    }
}