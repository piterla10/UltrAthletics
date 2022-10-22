
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface ILineaPedidoCAD
{
LineaPedidoEN ReadOIDDefault (int id
                              );

void ModifyDefault (LineaPedidoEN lineaPedido);

System.Collections.Generic.IList<LineaPedidoEN> ReadAllDefault (int first, int size);




int CrearLinea (LineaPedidoEN lineaPedido);

void ModificarLinea (LineaPedidoEN lineaPedido);


void Borrar (int id
             );


LineaPedidoEN ReadOID (int id
                       );


System.Collections.Generic.IList<LineaPedidoEN> ReadAll (int first, int size);



System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN> VerLineasPorPedido (int ped);
}
}
