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


        [Display(Prompt = "Nombre del producto", Description = "Nombre del producto", Name = "Nombre: ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el producto")]
        [DataType(DataType.Text, ErrorMessage = "El Nombre debe ser un texto")]
        [StringLength( maximumLength: 30, ErrorMessage = "El nombre debe tener como maximo 30 caracteres")]
        public String nombre { get; set; }
        

        [Display(Prompt = "Descripcion del producto", Description = "Descripcion del producto", Name = "Descripcion: ")]
        [Required(ErrorMessage = "Debe indicar un Descripcion para el producto")]
        [DataType(DataType.Text, ErrorMessage = "La Descripcion debe ser un texto")]
        [StringLength( maximumLength: 150, ErrorMessage = "El nombre debe tener como maximo 150 caracteres")]
        public String descripcion { get; set; }

        [Display(Prompt = "Precio del producto", Description = "Precio del producto", Name = "Precio: ")]
        [Required(ErrorMessage = "Debe indicar un precio para el producto")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 999999999, ErrorMessage = "El precio debe ser mayor que cero")]
        public float precio { get; set; }

        [Display(Prompt = "Lista de imagenes del producto", Description = "Lista de imagenes del producto", Name = "Lista de imagenes: ")]
        [Required(ErrorMessage = "Debe subir una imagen para el producto")]
        public IList<String> imagenes { get; set; }


    }
}