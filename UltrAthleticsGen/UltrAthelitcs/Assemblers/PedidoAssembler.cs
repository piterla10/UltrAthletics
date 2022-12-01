using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UltrAthelitcs.Models;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Assemblers
{
    public class PedidoAssembler
    {
        public PedidoViewModel ConvertEnToModelUI(PedidoEN en)
        {
            PedidoViewModel ped = new PedidoViewModel();
            ped.Id = en.Id;
            if (en.Fecha!=null)
            {
                ped.Fecha = (DateTime)en.Fecha;
            }
            ped.Direccion = en.Direccion;
            ped.Tarjeta = en.Tarjeta;
            ped.Estado = en.Estado;
            ped.Descuento = en.Descuento;
            ped.Seguimiento = en.Seguimiento;
            ped.Total = en.Total;
            ped.Devolver = en.Devolver;
            ped.Factura = en.Factura;
            ped.Usuario = en.Usuario;

            List<lineaPedidoResumen> pro = new List<lineaPedidoResumen>();
          
            foreach (var lin in en.LineaPedido)
            {
                lineaPedidoResumen aux = new lineaPedidoResumen();
                aux.Nombre = lin.Producto.Nombre;
                aux.Imagen = lin.Producto.Imagen[0];
                aux.Unidades = lin.Unidades;
                aux.Total = lin.Precio;
                
                pro.Add(aux);
            }
            ped.productos = pro;

            return ped;
        }

        public IList<PedidoViewModel> ConvertListENToModel(IList<PedidoEN> ens)
        {
            IList<PedidoViewModel> peds = new List<PedidoViewModel>();
            foreach (PedidoEN en in ens)
            {
                peds.Add(ConvertEnToModelUI(en));
            }
            return peds;
        }
    }
}