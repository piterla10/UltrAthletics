using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Models
{
    public class CategoriaViewModel
    {


        [Display(Prompt = "Nombre de la categoria", Description = "Nombre de la categoria", Name = "Nombre: ")]
        [Required(ErrorMessage = "Debe indicar un nombre para la categoria")]
        [DataType(DataType.Text, ErrorMessage = "El Nombre debe ser de tipo texto")]
        [StringLength(maximumLength: 30, ErrorMessage = "El nombre debe tener como maximo 30 caracteres")]
        public String Nombre { get; set; }


        [Display(Prompt = "Descripcion de la categoria", Description = "Descripcion de la categoria", Name = "Descripcion: ")]
        [Required(ErrorMessage = "Debe indicar una descripcion para la categoria")]
        [DataType(DataType.Text, ErrorMessage = "La descripcion debe ser de tipo texto")]
        [StringLength(maximumLength: 150, ErrorMessage = "La descripción debe tener como maximo 150 caracteres")]
        public String Descripcion { get; set; }

        /*
        [Display(Prompt = "Lista de productos", Description = "Lista de productos", Name = "Productos: ")]
        [Required(ErrorMessage = "Debe indicar los productos de categoria ")]
        public IList<ProductoEN> Producto { get; set; }


        [Display(Prompt = "Lista de eventos", Description = "Lista de eventos", Name = "Eventos: ")]
        [Required(ErrorMessage = "Debe indicar los eventos de categoria ")]
        public IList<EventoEN> Evento { get; set; }


        [Display(Prompt = "Lista de usuarios", Description = "Lista de usuarios", Name = "Usuarios: ")]
        [Required(ErrorMessage = "Debe indicar los usuarios de categoria ")]
        public IList<UsuarioEN> Usuario { get; set; }
        */
    }
}