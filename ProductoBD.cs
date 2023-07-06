using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPLabo2_2D
{
    public static class ProductoBD
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;


        static ProductoBD()
        {
            connectionString = @"Data Source=DESKTOP-DFGBI90;Initial Catalog=SPLabo2;Integrated Security = True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);        
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        public static List<Producto> Leer()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM PRODUCTOS";

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string tipoDeProductoString = dataReader["tipoDeProducto"].ToString();
                    EProdcuto tipoDeProducto = (EProdcuto)Enum.Parse(typeof(EProdcuto), tipoDeProductoString);

                    productos.Add(new Producto (tipoDeProducto, Convert.ToSingle(dataReader["precioPorKilo"]), 
                    Convert.ToSingle(dataReader["cantidadDeKilos"]), dataReader["nombre"].ToString(), Convert.ToInt32(dataReader["codigoDeProducto"])));
                }
                return productos;
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

        public static bool GuardarProducto(List<Producto> listaDeProductos)
        {
            bool retorno = true;
            try
            {
                connection.Open();
                foreach (Producto productos in listaDeProductos)
                {
                    if (!ProductoExisteEnBaseDeDatos(productos.CodigoDeProducto))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@tipoDeProducto", productos.TipoDeProducto);
                        command.Parameters.AddWithValue("@precioPorKilo", productos.PrecioPorKilo);
                        command.Parameters.AddWithValue("@cantidadDeKilos", productos.CantidadDeKilos);
                        command.Parameters.AddWithValue("@nombre", productos.Nombre);
                        command.Parameters.AddWithValue("@codigoDeProducto", productos.CodigoDeProducto);
                        //command.CommandText = $"INSERT INTO PRODUCTOS (tipoDeProducto,precioPorKilo,cantidadDeKilos,nombre)";

                        command.CommandText = $"INSERT INTO Productos(tipoDeProducto, precioPorKilo, cantidadDeKilos, nombre,codigoDeProducto) " +
                            $"Values(@tipoDeProducto,@precioPorKilo,@cantidadDeKilos,@nombre,@codigoDeProducto)";
                    }
                    
                    int filasAfectadas =  command.ExecuteNonQuery();
                    if (filasAfectadas == 0)
                    {
                        retorno = false;
                    }
                }                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {                
                connection.Close();   
            }
            return retorno;
        }
        private static bool ProductoExisteEnBaseDeDatos(int codigoDeProducto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.Parameters.Clear();
                command.CommandText = "SELECT COUNT(*) FROM PRODUCTOS WHERE CODIGODEPRODUCTO = @codigoDeProducto";
                command.Parameters.AddWithValue("@codigoDeProducto", codigoDeProducto);
                //ejecuta la consulta SQL en el comando command y devuelve un objeto que representa el valor del primer resultado de la consulta.

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
            catch (Exception) 
            {
                throw;
            }            
        }

        public static void Eliminar (Producto productoAEliminar)
        {           
            try
            {
                int codigoDeProducto = productoAEliminar.CodigoDeProducto;

                command.Parameters.Clear();
                connection.Open();               
                command.CommandText = "DELETE FROM PRODUCTOS WHERE CODIGODEPRODUCTO = @codigoDeProducto";
                command.Parameters.AddWithValue("@codigoDeProducto", codigoDeProducto);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception ("Error al conectar a la base de datos");
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Modificar(Producto nuevoProducto)
        {            
            try
            {          
                command.Parameters.Clear(); // Limpiar parámetros
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.Parameters.AddWithValue("@tipoDeProducto", nuevoProducto.TipoDeProducto);
                command.Parameters.AddWithValue("@precioPorKilo", nuevoProducto.PrecioPorKilo);
                command.Parameters.AddWithValue("@cantidadDeKilos", nuevoProducto.CantidadDeKilos);
                command.Parameters.AddWithValue("@nombre", nuevoProducto.Nombre);
                command.Parameters.AddWithValue("@codigoDeProducto", nuevoProducto.CodigoDeProducto);
                
                command.CommandText = "UPDATE Productos SET tipoDeProducto = @tipoDeProducto, cantidadDeKilos = @cantidadDeKilos, " +
                    "nombre = @nombre, precioPorKilo = @precioPorKilo WHERE CODIGODEPRODUCTO = @codigoDeProducto";
              
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Error al conectar a la base de datos");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        
        public static void Modificar(List<Producto> nuevosProductos)
        {
            foreach (Producto nuevoProducto in nuevosProductos)
            {
                try
                {
                    connection.Open();
                    if (nuevoProducto.CantidadSolicitada > 0 && ProductoExisteEnBaseDeDatos(nuevoProducto.CodigoDeProducto))
                    {
                        Modificar(nuevoProducto);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Error al conectar a la base de datos");
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }            
        }


    }
}
