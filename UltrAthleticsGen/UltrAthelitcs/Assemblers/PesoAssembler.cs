using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UltrAthelitcs.Models;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Assemblers
{
    public class PesoAssembler
    {
        public PesoViewModel ConvertENToModelUI(PesoEN en)
        {
            PesoViewModel pes = new PesoViewModel();
            pes.Cantidad = en.Cantidad;
            
            return pes;

        }

        public IList<PesoViewModel> ConvertListENToModel(IList<PesoEN> ens)
        {
            IList<PesoViewModel> pes = new List<PesoViewModel>();
            foreach (PesoEN en in ens)
            {
                pes.Add(ConvertENToModelUI(en));
            }
            return pes;

        }
    }
}