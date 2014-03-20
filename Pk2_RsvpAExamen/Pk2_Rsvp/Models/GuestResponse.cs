using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//usando para validar campo
using System.ComponentModel.DataAnnotations;


namespace Pk2_Rsvp.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage="Por Favor ingrese su nombre.")]
        public string Name { get; set; }

        [Required (ErrorMessage="Por favor ingrese su correo electronico.")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage="Favor de ingresar una nueva cuenta de correo valida")]
        public string Email { get; set; }

        [Required(ErrorMessage="Por favor ingrese su número telefónico.")]
        public string Phone { get; set; }

        [Required(ErrorMessage="Por favor especifique si asistira o no.")]
        public bool? WillAttend { get; set; }
    }
}