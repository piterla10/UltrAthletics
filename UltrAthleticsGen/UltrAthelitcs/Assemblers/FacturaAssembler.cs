using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UltrAthelitcs.Models;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Assemblers
{
    public class FacturaAssembler
    {

        public FacturaViewModel ConvertENToModelUI(FacturaEN en)
        {
            FacturaViewModel pro = new FacturaViewModel();
            pro.idFactura = en.Id;
            pro.Pedido = en.Pedido;
            return pro;

        }

        public IList<FacturaViewModel> ConvertListENToModel(IList<FacturaEN> ens)
        {
            IList<FacturaViewModel> pros = new List<FacturaViewModel>();
            foreach (FacturaEN en in ens)
            {
                pros.Add(ConvertENToModelUI(en));
            }
            return pros;

        }




    }
}