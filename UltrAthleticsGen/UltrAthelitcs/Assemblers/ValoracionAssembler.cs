using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UltrAthelitcs.Models;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Assemblers
{
    public class ValoracionAssembler
    {

        public ValoracionViewModel ConvertENToModelUI(ValoracionEN en)
        {
            ValoracionViewModel pro = new ValoracionViewModel();
            pro.idValoracion = en.Id;
            pro.Comentario = en.Comentario;
            pro.Valor = en.Valor;
            return pro;

        }

        public IList<ValoracionViewModel> ConvertListENToModel(IList<ValoracionEN> ens)
        {
            IList<ValoracionViewModel> pros = new List<ValoracionViewModel>();
            foreach (ValoracionEN en in ens)
            {
                pros.Add(ConvertENToModelUI(en));
            }
            return pros;

        }




    }
}