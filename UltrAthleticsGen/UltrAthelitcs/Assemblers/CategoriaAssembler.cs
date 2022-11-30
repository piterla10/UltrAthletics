using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UltrAthelitcs.Models;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Assemblers
{
    public class CategoriaAssembler
    {
        public CategoriaViewModel ConvertENToModelUI(CategoriaEN en)
        {
            CategoriaViewModel cat = new CategoriaViewModel();
            cat.Nombre = en.Nombre;
            cat.Descripcion = en.Descripcion;
            // faltarian las listas de vergas
            return cat;

        }

        public IList<CategoriaViewModel> ConvertListENToModel(IList<CategoriaEN> ens)
        {
            IList<CategoriaViewModel> cats = new List<CategoriaViewModel>();
            foreach (CategoriaEN en in ens)
            {
                cats.Add(ConvertENToModelUI(en));
            }
            return cats;

        }
    }
}