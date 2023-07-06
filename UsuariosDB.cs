using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public static class UsuariosDB
    {

        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static UsuariosDB()
        {
            connectionString = @"Data Source=DESKTOP-DFGBI90;Initial Catalog=SPLabo2;Integrated Security = True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        internal static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM USUARIOS";

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    //string nombreUsuario, string contrasenia, string nombre, int tipoDeUsuario)

                    usuarios.Add(new Usuario(dataReader["nombreUsuario"].ToString(), dataReader["contrasenia"].ToString(),
                    nombre: dataReader["nombre"].ToString(), tipoDeUsuario: Convert.ToInt32(dataReader["tipoDeUsuario"])));

                }
                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        //internal static List<Usuario> Leer()
        //{
        //    List<Usuario> usuarios = new List<Usuario>();

        //    try
        //    {
        //        connection.Open();
        //        command.CommandText = $"SELECT * FROM USUARIOS";

        //        SqlDataReader dataReader = command.ExecuteReader();
        //        while (dataReader.Read())
        //        {
        //            string nombreUsuario = dataReader["nombreUsuario"].ToString();
        //            string contrasenia = dataReader["contrasenia"].ToString();
        //            string nombre = dataReader["nombre"].ToString();
        //            int tipoDeUsuario = Convert.ToInt32(dataReader["tipoDeUsuario"]);

        //            Usuario usuario;

        //            if (tipoDeUsuario == 0)
        //            {
        //                // Es un vendedor
        //                usuario = new Vendedor(nombreUsuario, contrasenia, nombre);
        //            }
        //            else if (tipoDeUsuario == 1)
        //            {
        //                // Es un cliente
        //                usuario = new Cliente(nombreUsuario, contrasenia, nombre);
        //            }
        //            else
        //            {
        //                // Tipo de usuario desconocido
        //                throw new Exception("Tipo de usuario desconocido.");
        //            }

        //            usuarios.Add(usuario);
        //        }

        //        return usuarios;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}



        public static Usuario LoginTipoDeUsuario(string nombreUsuario, string contrasenia)
        {
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM USUARIOS WHERE nombreUsuario = @nombreUsuario AND contrasenia = @contrasenia";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                command.Parameters.AddWithValue("@contrasenia", contrasenia);

                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    int tipoDeUsuario = Convert.ToInt32(dataReader["tipoDeUsuario"]);
                    if (tipoDeUsuario == 1)
                    {
                        // Tipo de usuario Cliente
                        return new Cliente(dataReader["nombreUsuario"].ToString(), dataReader["contrasenia"].ToString(),
                            nombre: dataReader["nombre"].ToString());
                    }
                    else if (tipoDeUsuario == 0)
                    {
                        // Tipo de usuario Vendedor
                        return new Usuario (dataReader["nombreUsuario"].ToString(), dataReader["contrasenia"].ToString(),
                            nombre: dataReader["nombre"].ToString());
                    }
                }

                return null; // No se encontró un usuario con las credenciales especificadas o con un tipo de usuario válido
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
