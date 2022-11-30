
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CEN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;
using UltrAthleticsGenNHibernate.CP.UltrAthletics;
using UltrAthleticsGenNHibernate.Enumerated.UltrAthletics;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                //creando objetos CEN
                UsuarioCEN usuarioCEN = new UsuarioCEN ();
                ProductoCEN productoCEN = new ProductoCEN ();
                ValoracionCEN valoracionCEN = new ValoracionCEN ();
                ValoracionCP valoracionCP = new ValoracionCP ();
                PedidoCEN pedidoCEN = new PedidoCEN ();
                LineaPedidoCEN lineaPedidoCEN = new LineaPedidoCEN ();
                CategoriaCEN categoriaCEN = new CategoriaCEN ();
                PedidoCP pedidoCP = new PedidoCP ();
                FacturaCEN facturaCEN = new FacturaCEN ();
                DevolucionCEN devolucionCEN = new DevolucionCEN ();
                EventoCEN eventoCEN = new EventoCEN ();


                //creamos todos los objetos CP
                ProductoCP productoCP = new ProductoCP ();
                UsuarioCP usuarioCP = new UsuarioCP ();

                //creando usuarios
                String idUsuario = usuarioCEN.CrearUsuario ("correoChuli@correo", "1234", RolesEnum.admin);
                String idJuan = usuarioCEN.CrearUsuario ("juan@correo", "1234", RolesEnum.cliente);

                UsuarioEN usuarioEN = new UsuarioEN ();
                usuarioEN = usuarioCEN.DameUsuarioOID (idUsuario);

                UsuarioEN juanEN = new UsuarioEN ();
                juanEN = usuarioCEN.DameUsuarioOID (idJuan);


                //Creando pedidos
                int idped = pedidoCEN.CrearPedido (EstadoPedidoEnum.carrito, "correoChuli@correo");
                PedidoEN pedEN = pedidoCEN.DamePedidoOID (idped);




                //Creando productos
                ProductoEN pro1EN = new ProductoEN ();
                int idpro1 = productoCEN.CrearProducto ("proteina", "grande", 36, 5, 0, new List<String>{ "../assets/img/proteina.png"});
                pro1EN = productoCEN.DameProductoOID (idpro1);

                ProductoEN pro2EN = new ProductoEN ();
                int idpro2 = productoCEN.CrearProducto ("mancuerna", "pequeña", 30, 2, 0, new List<String> { "../assets/img/mancuerna.jpg", "../assets/img/mancuerna1.jpg" });
                pro2EN = productoCEN.DameProductoOID (idpro2);

                ProductoEN pro3EN = new ProductoEN ();
                int idpro3 = productoCEN.CrearProducto ("batido", "mediano", 40, 4, 0, new List<String> { "../assets/img/batido mediano.jpg" });
                pro3EN = productoCEN.DameProductoOID (idpro3);


                //creando lineas de pedido
                int idLinea1 = lineaPedidoCEN.CrearLinea (3, idped, 50, idpro1);
                LineaPedidoEN linea1EN = lineaPedidoCEN.DameLineaPedidoOID (idLinea1);
                int idLinea2 = lineaPedidoCEN.CrearLinea (1, idped, 15, idpro2);


                //creando valoraciones
                int val4 = valoracionCP.CrearValoracion ("muy bueno", 4, idUsuario, idpro1).Id;
                int val51 = valoracionCP.CrearValoracion ("perfecto", 5, idJuan, idpro1).Id;
                int val52 = valoracionCP.CrearValoracion ("uma delisia", 5, "correoChuli@correo", idpro1).Id;
                int val10 = valoracionCP.CrearValoracion ("uma delisia", 10, "correoChuli@correo", idpro1).Id;


                //creamos una categoria
                CategoriaEN categoriaEN = new CategoriaEN ();
                String idCategoria1 = categoriaCEN.CrearCategoria ("natación", "deportes de natación");
                categoriaEN = categoriaCEN.DameCategoriaOID (idCategoria1);


                //creaar pesos
                PesoCEN pesoCEN = new PesoCEN ();
                string idPes1 = pesoCEN.CrearPeso ("5");
                string idPes2 = pesoCEN.CrearPeso ("2");



                //crear sabor
                SaborCEN saborCEN = new SaborCEN ();
                string idSab2 = saborCEN.CrearSabor ("limon");

                string idSab1 = saborCEN.CrearSabor ("azul");

                productoCEN.AnyadirPeso (idpro1, new List<string> { idPes1, idPes2 });
                productoCEN.AnyadirSabor (idpro1, new List<string> { idSab1, idSab2 });

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos los readFilter de sabor y peso de los productos");

                IList<ProductoEN> productoPeso = productoCEN.DameProductoPorPeso (idPes1);
                Console.WriteLine ("Productos con peso= " + idPes1);
                foreach (ProductoEN pro in productoPeso) {
                        Console.WriteLine (pro.Nombre);
                }
                Console.WriteLine ("***********************************");

                IList<ProductoEN> productoSabor = productoCEN.DameProductoPorSabor (idSab2);
                Console.WriteLine ("Productos con sabor= " + idSab2);
                foreach (ProductoEN pro in productoSabor) {
                        Console.WriteLine (pro.Nombre);
                }
                Console.WriteLine ("***********************************");


                //probamos el inicio de sesion
                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos si se inicia sesion con el usuairo " + usuarioEN.Email);
                if (usuarioCEN.IniciarSesion ("correoChuli@correo", "1234") != null) {
                        Console.WriteLine ("Inicio de sesion correcto");
                }


                //decrementas el stock
                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo decrementarStock y incrementarStock");

                Console.WriteLine ("Producto: " + pro1EN.Nombre + " Stock inicial " + pro1EN.Stock);
                productoCEN.DecrementarStock (idpro1, 3);
                pro1EN = productoCEN.DameProductoOID (idpro1);
                Console.WriteLine ("Producto : " + pro1EN.Nombre + " Stock decrementado (le hemos quitado 3) " + pro1EN.Stock);

                productoCEN.IncrementarStock (idpro1, 6);
                pro1EN = productoCEN.DameProductoOID (idpro1);
                Console.WriteLine ("Producto : " + pro1EN.Nombre + " Stock incrementado (le hemos incrementado en 6) " + pro1EN.Stock);

                //Probamos asignar categoria y los productos relacionados a esa categoria
                productoCEN.AsignarCategoria (idpro1, new List<String>{ "natación" });
                productoCEN.AsignarCategoria (idpro2, new List<String> { "natación" });

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo DameProductoPorCategoria con la categoria: " + categoriaEN.Nombre);
                IList<ProductoEN> lsta = productoCEN.DameProductoPorCategoria (categoriaEN.Nombre);
                foreach (ProductoEN pro in lsta) {
                        Console.WriteLine ("Producto : " + pro.Nombre);
                }

                //uso calcular macronutrientes
                Console.WriteLine ("***********************************");
                Console.WriteLine ("Pruebo el metodo calcularMacronutrientes");
                usuarioCEN.CalcularMacronutrientes (EstiloVidaEnum.fuerte, ObjetivosEnum.volumen, 92, 180, SexoEnum.hombre, "correoChuli@correo", 21);


                //anyadienco productos a deseados y los mostramos por pantalla
                usuarioCEN.AnyadirDeseado ("correoChuli@correo", new List<int> { idpro1, idpro2 });

                //probamos el metodo para RecuperarContrasenya
                //Console.WriteLine ("***********************************");
                //usuarioCEN.RecuperarContrasenya (idUsuario);


                pedEN = pedidoCEN.DamePedidoOID (idped);

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo VerLineasPorPedido");
                IList<LineaPedidoEN> listalienas = lineaPedidoCEN.VerLineasPorPedido (idped);
                int x = 1;
                Console.WriteLine ("Lineas del pedido ");
                foreach (LineaPedidoEN lon in listalienas) {
                        Console.WriteLine ("Linea " + x + " " + lon.Id + " " + lon.Pedido.Id);

                        x++;
                }


                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo CalcularTotal(CP) y getTotalLinea(CP) del pedido anterior ");
                Console.WriteLine ("TOTAL = " + pedidoCP.CalcularTotal (idped));


                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo DamePedidoUsuario ");
                IList<PedidoEN> listaPedEN = pedidoCEN.DamePedidoUsuario (idUsuario);
                int y = 1;
                Console.WriteLine ("pedidos de " + usuarioEN.Email);
                foreach (PedidoEN ped in listaPedEN) {
                        Console.WriteLine ("Pedido " + y + " " + ped.Id);
                        y++;
                }

                Console.WriteLine ("***********************************");
                Console.WriteLine ("El estado inicial del pedido es" + pedEN.Estado);

                Console.WriteLine ("Probamos el metodo PagarPedido ");
                pedidoCEN.PagarPedido (idped, "aqui", "esta", 0);
                pedEN = pedidoCEN.DamePedidoOID (idped);
                Console.WriteLine ("El estado actual del pedido es: " + pedEN.Estado);


                Console.WriteLine ("***");
                Console.WriteLine (pedEN.Fecha);
                Console.WriteLine ("Probamos el metodo damePedidoUusarioUltimoMes");
                DateTime fechaActual = DateTime.Today;
                Console.WriteLine ("pedidos de " + usuarioEN.Email + " en el mes: " + fechaActual.ToString ("MMMM"));
                IList<PedidoEN> listaPedENMesActual = pedidoCEN.DamePedidoPorUsuarioYMes (idUsuario, DateTime.Today.Month, DateTime.Today.Year);

                foreach (PedidoEN ped in listaPedENMesActual) {
                        Console.WriteLine ("Pedido " + ped.Id + " fecha: " + ped.Fecha);
                }


                Console.WriteLine ("Probamos el metodo EnviarPedido ");
                pedidoCEN.EnviarPedido (idped);
                pedEN = pedidoCEN.DamePedidoOID (idped);
                Console.WriteLine ("El estado actual del pedido: " + pedEN.Estado);

                Console.WriteLine ("Probamos el metodo EntregarPedido ");
                pedidoCEN.EntregarPedido (idped);
                pedEN = pedidoCEN.DamePedidoOID (idped);
                Console.WriteLine ("El estado actual del pedido es: " + pedEN.Estado);

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo GetMediaValoraciones");
                Console.WriteLine ("Media de valoraciones:");
                Console.WriteLine (pro1EN.MediaValoracion);
                Console.WriteLine ("Total de valoraciones:");
                Console.WriteLine (pro1EN.TotalValoracion);
                valoracionCP.ModificarValoracion (val10, "no tan bueno", 9);
                pro1EN = productoCEN.DameProductoOID (idpro1);
                Console.WriteLine ("Media de valoraciones despues de modificar 10 a 9:");
                Console.WriteLine (pro1EN.MediaValoracion);
                Console.WriteLine ("Total de valoraciones despues de modificar 10 a 9:");
                Console.WriteLine (pro1EN.TotalValoracion);
                valoracionCP.BorrarValoracion (val4);
                pro1EN = productoCEN.DameProductoOID (idpro1);
                Console.WriteLine ("Media de valoraciones despues de borrar 4:");
                Console.WriteLine (pro1EN.MediaValoracion);
                Console.WriteLine ("Total de valoraciones despues de borrar 4:");
                Console.WriteLine (pro1EN.TotalValoracion);

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Creamos factura y devolucion");
                int facid = facturaCEN.CrearFactura (idped);
                int devid = devolucionCEN.CrearDevolucion (idped, "no me gusta");

                DevolucionEN dev = devolucionCEN.DameDevolucionOID (devid);

                Console.WriteLine ("ID de factura: " + facid);
                Console.WriteLine ("ID de devolucion: " + devid);
                Console.WriteLine ("Motivo de devolucion: " + dev.Motivo);

                pedidoCEN.GetCodigoDevolucion (idped);

                Console.WriteLine ("ID de factura: " + facid);
                Console.WriteLine ("ID de devolucion: " + devid);
                Console.WriteLine ("Motivo de devolucion: " + dev.Motivo);

                pedidoCEN.GetCodigoDevolucion (idped);

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos ReadFilter DameProductoPorPrecio");
                IList<ProductoEN> preciolis = productoCEN.DameProductoPorPrecio (90, 30);
                foreach (ProductoEN pro in preciolis) {
                        Console.WriteLine ("Producto : " + pro.Nombre);
                }

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos ReadFilter DameEventosPorMes");
                eventoCEN.CrearEvento (DateTime.Today, "aquimismo.com", "una chula", "Tour de Francia");
                eventoCEN.CrearEvento (DateTime.Today.AddDays (-31), "aquimismo.com", "una chula", "Tour de Francia");
                IList<EventoEN> eventos = eventoCEN.DameEventoPorMes (2022, 10);
                foreach (EventoEN ev in eventos) {
                        Console.WriteLine ("Evento : " + ev.Nombre);
                }

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos ReadFilter DameEventosPorDia");
                eventos = eventoCEN.DameEventoPorDia (2022, 11, 10);
                foreach (EventoEN ev in eventos) {
                        Console.WriteLine ("Evento : " + ev.Nombre);
                }

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos ReadFilter DameUsuarioPorCategoria y los Relationer/Unrelationer anyadir y eliminar CategoriaPreferencia");
                IList<UsuarioEN> usuarios = usuarioCEN.DameUsuarioPorCategoria ("natación");
                Console.WriteLine ("Antes de anyadir:");
                foreach (UsuarioEN ev in usuarios) {
                        Console.WriteLine ("Usuario : " + ev.Email);
                }
                usuarioCEN.AnyadirCategoriaPreferencia ("correoChuli@correo", new List<String> { "natación" });
                usuarios = usuarioCEN.DameUsuarioPorCategoria ("natación");
                Console.WriteLine ("Despues de anyadir:");
                foreach (UsuarioEN ev in usuarios) {
                        Console.WriteLine ("Usuario : " + ev.Email);
                }
                usuarioCEN.EliminarCategoriaPreferencia ("correoChuli@correo", new List<String> { "natación" });
                usuarios = usuarioCEN.DameUsuarioPorCategoria ("natación");
                Console.WriteLine ("Despues de eliminar:");
                foreach (UsuarioEN ev in usuarios) {
                        Console.WriteLine ("Usuario : " + ev.Email);
                }

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Obtenemos los deseados (CP)");
                IList<ProductoEN> deseados = usuarioCP.DameDeseados ("correoChuli@correo");
                foreach (ProductoEN pro in deseados) {
                        Console.WriteLine ("Producto " + pro.Nombre);
                }

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
