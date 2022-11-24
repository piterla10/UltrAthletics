using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Models
{
    public class FacturaViewModel
    {
        [Display(Prompt = "ID devolucion", Description = "ID devolucion", Name = "Id: ")]
        [Required(ErrorMessage = "Debe indicar un id para la devolucion")]
        public int idFactura { get; set; }


        [Display(Prompt = "Pedido del producto", Description = "Factura del producto concreto", Name = "Factura: ")]
        [Required(ErrorMessage = "Debe indicar un pedido para la factura")]
        public PedidoEN Pedido { get; set; }



    }
}