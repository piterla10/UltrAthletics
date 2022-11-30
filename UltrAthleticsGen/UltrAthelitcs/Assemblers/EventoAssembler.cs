using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UltrAthelitcs.Models;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Assemblers
{
    public class EventoAssembler
    {
        public EventoViewModel ConvertENToModelUI(EventoEN en)
        {
            EventoViewModel eve = new EventoViewModel();
            eve.IdEvento = en.Id;
            eve.Nombre = en.Nombre;
            //eve.categoria = en.Categoria;
            eve.Fecha = en.Fecha;
            eve.Imagen = en.Imagen;
            return eve;

        }

        public IList<EventoViewModel> ConvertListENToModel(IList<EventoEN> ens)
        {
            IList<EventoViewModel> eves = new List<EventoViewModel>();
            foreach (EventoEN en in ens)
            {
                eves.Add(ConvertENToModelUI(en));
            }
            return eves;

        }

    }
}