using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UltrAthelitcs.Models;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Assemblers
{
    public class DevolucionAssembler
    {

        public DevolucionViewModel ConvertENToModelUI(DevolucionEN en)
        {
            DevolucionViewModel pro = new DevolucionViewModel();
            pro.idDevolucion = en.Id;
            pro.Pedido = en.Pedido;
            pro.Motivo = en.Motivo;
            pro.Creacion = en.Creacion;
            return pro;

        }

        public IList<DevolucionViewModel> ConvertListENToModel(IList<DevolucionEN> ens)
        {
            IList<DevolucionViewModel> pros = new List<DevolucionViewModel>();
            foreach (DevolucionEN en in ens)
            {
                pros.Add(ConvertENToModelUI(en));
            }
            return pros;

        }




    }
}