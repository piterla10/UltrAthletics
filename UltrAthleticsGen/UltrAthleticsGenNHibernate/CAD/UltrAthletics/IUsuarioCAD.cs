
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string email
                          );

void ModifyDefault (UsuarioEN usuario);

System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size);




string CrearCuenta (UsuarioEN usuario);



void Modificar (UsuarioEN usuario);


void Borrar (string email
             );


UsuarioEN DameUsuariosOID (string email
                           );


System.Collections.Generic.IList<UsuarioEN> DameUsuarioTodos (int first, int size);



void AnadirCategoria (string p_Usuario_OID, System.Collections.Generic.IList<string> p_categoria_OIDs);
}
}
