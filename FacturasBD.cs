using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public static class FacturasBD
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static FacturasBD()
        {
            connectionString = @"Data Source=DESKTOP-DFGBI90;Initial Catalog=SPLabo2;Integrated Security = True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static List<Factura> Leer()
        {
            List<Factura> facturasBd = new List<Factura>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM FACTURAS";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int numeroFactura = Convert.ToInt32(dataReader["Nº"]);
                        DateTime fecha = Convert.ToDateTime(dataReader["Fecha"]);
                        string nombre = dataReader["Nombre"].ToString();
                        double total = Convert.ToDouble(dataReader["Total"]);

                        Factura factura = new Factura(numeroFactura, fecha, nombre, total);
                        facturasBd.Add(factura);
                    }
                }

                return facturasBd;
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


        public static bool GuardarFacturas(List<Factura> listaDeFacturas)
        {
            bool retorno = true;
            try
            {
                connection.Open();

                foreach (Factura factura in listaDeFacturas)
                {                        
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Numero", factura.NumeroDeFactura);
                    command.Parameters.AddWithValue("@Fecha", factura.FechaActual);
                    command.Parameters.AddWithValue("@Nombre", factura.Nombre);
                    double totalRedondeado = Math.Round(factura.TotalFactura, 2);
                    command.Parameters.AddWithValue("@Total", totalRedondeado);
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO FACTURAS (Nº, Fecha, Nombre, Total) VALUES (@Numero, @Fecha, @Nombre, @Total)";
                }
                int filasAfectadas = command.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    retorno = false;
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
        public static bool GuardarFacturas(Factura factura)
        {
            try
            {
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Numero", factura.NumeroDeFactura);
                command.Parameters.AddWithValue("@Fecha", factura.FechaActual);
                command.Parameters.AddWithValue("@Nombre", factura.Nombre);                
                double totalRedondeado = Math.Round(factura.TotalFactura, 2);
                command.Parameters.AddWithValue("@Total", totalRedondeado);

                command.CommandText = "INSERT INTO FACTURAS (Nº, Fecha, Nombre, Total) VALUES (@Numero, @Fecha, @Nombre, @Total)";

                int filasAfectadas = command.ExecuteNonQuery();
                return filasAfectadas > 0;
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
