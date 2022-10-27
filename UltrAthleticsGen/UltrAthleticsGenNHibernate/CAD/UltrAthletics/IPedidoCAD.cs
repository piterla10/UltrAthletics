
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface IPedidoCAD
{
PedidoEN ReadOIDDefault (int id
                         );

void ModifyDefault (PedidoEN pedido);

System.Collections.Generic.IList<PedidoEN> ReadAllDefault (int first, int size);



int CrearPedido (PedidoEN pedido);


void ModificarPedido (PedidoEN pedido);


void BorrarPedido (int id
                   );


PedidoEN DamePedidoOID (int id
                        );


System.Collections.Generic.IList<PedidoEN> DamePedidoTodos (int first, int size);




System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN> DamePedidoUsuario (string usuario);






System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN> VerCarrito (string usu);
}
}
