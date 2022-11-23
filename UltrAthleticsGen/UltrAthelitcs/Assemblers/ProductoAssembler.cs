using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UltrAthelitcs.Models;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Assemblers
{
    public class ProductoAssembler
    {

        public ProductoViewModel ConvertENToModelUI(ProductoEN en)
        {
            ProductoViewModel pro = new ProductoViewModel();
            pro.idProducto = en.Id;
            pro.nombre = en.Nombre;
            pro.descripcion = en.Descripcion;
            pro.precio = en.Precio;
            pro.imagenes = en.Imagen;
            return pro;

        }

        public IList<ProductoViewModel> ConvertListENToModel(IList<ProductoEN> ens)
        {
            IList<ProductoViewModel> pros = new List<ProductoViewModel>();
            foreach(ProductoEN en in ens)
            {
                pros.Add(ConvertENToModelUI(en));
            }
            return pros;

        }




    }
}