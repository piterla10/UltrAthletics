using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UltrAthelitcs.Models
{
    public class ProductoViewModel
    {
        [ScaffoldColumn(false)]
        public int idProducto { get; set; }


        [Display(Prompt = "Nombre del artículo", Description = "Nombre del artículo", Name = "Nombre: ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el artículo")]
        [DataType(DataType.Text, ErrorMessage = "El Nombre debe ser un texto")]
        [StringLength( maximumLength: 30, ErrorMessage = "El nombre debe tener como maximo 30 caracteres", MinimumLength= 2)]
        public String Nombre { get; set; }
        /*

        [Display(Prompt = "Precio del artículo", Description = "Precio del artículo", Name = "Precio: ")]
        [Required(ErrorMessage = "Debe indicar un precio para el artículo")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 1000, ErrorMessage = "El precio debe ser mayor que cero")]
        public float precio { get; set; }*/


    }
}