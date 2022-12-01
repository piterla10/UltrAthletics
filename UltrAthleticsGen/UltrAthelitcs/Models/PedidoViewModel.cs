using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.Enumerated.UltrAthletics;

namespace UltrAthelitcs.Models
{
    public class PedidoViewModel
    {
        public int Id { get; set; }

        [Display(Prompt = "Fecha de entrega del pedido", Description = "Fecha de entrega del pedido", Name = "Fecha ")]
        [DataType(DataType.Date, ErrorMessage = "La fecha debe ser un valor Date")]
        public DateTime Fecha { get; set; }

        [Display(Prompt = "Direccion de envío", Description = "Dirección de envío", Name = "Dirección ")]
        [StringLength(maximumLength: 200, ErrorMessage = "La dirección no puede tener más de 200 caracteres")]
        public string Direccion { get; set; }

        [Display(Prompt = "Tarjeta de pago", Description = "Tarjeta de pago", Name = "Tarjeta ")]
        [DataType(DataType.CreditCard, ErrorMessage = "El número de tarjeta no es válido")]
        public string Tarjeta { get; set; }

        [Display(Prompt = "Estado del envío", Description = "Estado del envío", Name = "Estado ")]
        [Required(ErrorMessage = "Debe indicar un estado del envío")]
        [StringLength(maximumLength: 20, ErrorMessage = "El estado del pedido no puede tener más de 20 caracteres")]
        public EstadoPedidoEnum Estado { get; set; }

        [Display(Prompt = "Descuento del pedido", Description = "Descuento del pedido", Name = "Descuento ")]
        public double Descuento { get; set; }

        [Display(Prompt = "Codigo de seguimiento", Description = "Codigo de seguimiento", Name = "Seguimiento ")]
        [StringLength(maximumLength: 20, ErrorMessage = "El código de seguimiento del pedido no puede tener más de 20 caracteres")]
        public string Seguimiento { get; set; }

        [Display(Prompt = "Precio total del pedido", Description = "Precio total del pedido", Name = "Total ")]
        public float Total { get; set; }

        [Display(Prompt = "Devolucion del pedido", Description = "Devolución del pedido", Name = "Devolución ")]
        public IList<DevolucionEN> Devolver { get; set; }

        [Display(Prompt = "Factura del pedido", Description = "Factura del pedido", Name = "Factura ")]
        public FacturaEN Factura { get; set; }

        [Display(Prompt = "Lineas del pedido", Description = "Lineas del pedido", Name = "Lineas ")]
        public IList<lineaPedidoResumen> productos { get; set; }

        [Display(Prompt = "Usuario del pedido", Description = "Usuario del pedido", Name = "Usuario ")]
        [Required(ErrorMessage = "Debe indicar un usuario")]
        [StringLength(maximumLength: 30, ErrorMessage = "El nombre de usuario no puede tener más de 30 caracteres")]
        public UsuarioEN Usuario { get; set; }
    }
}