using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UltrAthelitcs.Models
{
    public class ValoracionViewModel
    {
        [ScaffoldColumn(false)]
        public int idValoracion { get; set; }


        [Display(Prompt = "Comentario del producto", Description = "Comentario del producto", Name = "Comentario: ")]
        [Required(ErrorMessage = "Debe indicar un comentario para la valoracion")]
        [DataType(DataType.Text, ErrorMessage = "El Comentario debe ser un texto")]
        [StringLength(maximumLength: 10000000, ErrorMessage = "Debe haber algo escrito en el comentario", MinimumLength = 0)]
        public String Comentario { get; set; }



        [Display(Prompt = "Valor del producto", Description = "Valor del producto", Name = "Valor: ")]
        [Required(ErrorMessage = "Debe indicar un valor")]
        [DataType(DataType.Text, ErrorMessage = "El valor debe ser un texto")]
        [StringLength(maximumLength: 10, ErrorMessage = "Debe estar entre 0-10 la valoracion", MinimumLength = 0)]
        public int Valor { get; set; }

    }
}