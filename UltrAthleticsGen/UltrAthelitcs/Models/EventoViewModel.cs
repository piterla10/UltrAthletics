using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Models
{
    public class EventoViewModel
    {
        [ScaffoldColumn(false)]
        public int IdEvento { get; set; }


        [Display(Prompt = "Nombre del evento", Description = "Nombre del evento", Name = "Nombre: ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el producto")]
        [DataType(DataType.Text, ErrorMessage = "El Nombre debe ser un texto")]
        [StringLength(maximumLength: 30, ErrorMessage = "El nombre debe tener como maximo 30 caracteres")]
        public String Nombre { get; set; }

        [Display(Prompt = "Nombre del evento", Description = "Nombre del evento", Name = "Url: ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el producto")]
        [DataType(DataType.Text, ErrorMessage = "El Nombre debe ser un texto")]
        [StringLength(maximumLength: 30, ErrorMessage = "El nombre debe tener como maximo 30 caracteres")]
        public String Url { get; set; }


        [Display(Prompt = "Fecha del evento", Description = "Fecha del evento", Name = "Fecha: ")]
        [Required(ErrorMessage = "Debe indicar la fecha del evento")]
        [DataType(DataType.DateTime, ErrorMessage = "La fecha debe estar en formato dd/mm/aaa")]
        public DateTime? Fecha { get; set; }

        /*
        [Display(Prompt = "Categoria del evento", Description = "Categoria del evento", Name = "Categoria: ")]
        [Required(ErrorMessage = "Debe indicar la categoria del evento")]
        public IList<CategoriaEN> Categoria { get; set; }
        */
        [Display(Prompt = "Imagen del evento", Description = "Imagen del evento", Name = "Imagen: ")]
        [Required(ErrorMessage = "Debe subir una imagen para el producto")]
        public String Imagen { get; set; }
        

    }
}