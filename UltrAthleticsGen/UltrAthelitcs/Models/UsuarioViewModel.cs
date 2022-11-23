using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UltrAthelitcs.Models
{
    public class UsuarioViewModel
    {
        [Display(Prompt = "Nombre del usuario", Description = "Nombre del usuario", Name = "Nombre: ")]
        public String Email { get; set; }


        [Display(Prompt = "Nombre del usuario", Description = "Nombre del usuario", Name = "Nombre: ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el artículo")]
        [DataType(DataType.Text, ErrorMessage = "El Nombre debe ser un texto")]
        [StringLength(maximumLength: 30, ErrorMessage = "El nombre debe tener como maximo 30 caracteres", MinimumLength = 2)]
        public String Nombre { get; set; }

    }
}