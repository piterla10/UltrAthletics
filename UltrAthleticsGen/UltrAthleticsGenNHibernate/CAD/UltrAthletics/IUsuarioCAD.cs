
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




string CrearUsuario (UsuarioEN usuario);



void ModificarUsuario (UsuarioEN usuario);


void BorrarUsuario (string email
                    );


UsuarioEN DameUsuarioOID (string email
                          );


System.Collections.Generic.IList<UsuarioEN> DameUsuarioTodos (int first, int size);



void AnyadirCategoriaPreferencia (string p_Usuario_OID, System.Collections.Generic.IList<string> p_categoria_OIDs);

void EliminarCategoriaPreferencia (string p_Usuario_OID, System.Collections.Generic.IList<string> p_categoria_OIDs);


void AnyadirDeseado (string p_Usuario_OID, System.Collections.Generic.IList<int> p_listaDeseados_OIDs);

void EliminarDeseado (string p_Usuario_OID, System.Collections.Generic.IList<int> p_listaDeseados_OIDs);
}
}
