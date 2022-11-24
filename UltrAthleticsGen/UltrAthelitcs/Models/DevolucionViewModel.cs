using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Models
{
    public class DevolucionViewModel
    {
        [Display(Prompt = "ID devolucion", Description = "ID devolucion", Name = "Id: ")]
        [Required(ErrorMessage = "Debe indicar un id para la devolucion")]
        public int idDevolucion { get; set; }


        [Display(Prompt = "Pedido del producto", Description = "Pedido del producto devuelto", Name = "Pedido Devolucion: ")]
        [Required(ErrorMessage = "Debe indicar un pedido para la devolucion")]
        [DataType(DataType.Text, ErrorMessage = "El Comentario debe ser un texto")]
        [StringLength(maximumLength: 10000000, ErrorMessage = "Debe haber algo escrito en el Pedido", MinimumLength = 0)]
        public PedidoEN Pedido { get; set; }




        [Display(Prompt = "motivo de la devolucion", Description = "Comentario de la devolucion", Name = "Devolucion: ")]
        [Required(ErrorMessage = "Debe indicar un motivo para la devolucion")]
        [DataType(DataType.Text, ErrorMessage = "El motivo debe ser un texto")]
        [StringLength(maximumLength: 10000000, ErrorMessage = "Debe haber algo escrito en el motivo", MinimumLength = 0)]
        public String Motivo { get; set; }


        [Display(Prompt = "Creacion de la devolucion", Description = "Creacion de la devolucion", Name = "Creacion: ")]
        [Required(ErrorMessage = "Debe indicar una creacion de devolucion")]
        [DataType(DataType.Text, ErrorMessage = "La creacion debe ser texto")]
        [StringLength(maximumLength: 10000000, ErrorMessage = "Debe haber algo escrito en la creacion", MinimumLength = 0)]
        public String Creacion { get; set; }

    }
}