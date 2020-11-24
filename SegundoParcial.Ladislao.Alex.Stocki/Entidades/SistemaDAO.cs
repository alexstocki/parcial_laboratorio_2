using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class SistemaDAO
    {
        static SqlConnection conexion;
        static SqlCommand comando;

        /// <summary>
        /// Se establece una conexion con la base de datos
        /// </summary>
        static SistemaDAO()
        {
            string connectionString = "Data Source= .\\SQLEXPRESS; Initial Catalog=SistemaDB;Trusted_Connection=True;";
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        /// <summary>
        /// Recupera la cabecera de las compras que se encuentran en preparacion
        /// </summary>
        /// <returns></returns>
        public static List<Compra> MostrarComprasNoListas()
        {
            try
            {
                List<Compra> compras = new List<Compra>();
                string txtQuery = $"SELECT * FROM Compra_total WHERE estado = 'En Preparacion'";

                SqlCommand comando = new SqlCommand(txtQuery, conexion);

                conexion.Open();

                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    compras.Add(new Compra(int.Parse(dataReader["id_compra"].ToString()), dataReader["cliente"].ToString(), (Compra.TipoEntrega)Enum.Parse(typeof(Compra.TipoEntrega), dataReader["tipo_entrega"].ToString()), dataReader["direccion"].ToString()));
                }

                return compras;
            }

            catch (Exception)
            {
                // crear excepcion de compras
                throw;
            }

            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Recupera las cabeceras de las compras listas para entregar de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Compra> MostrarComprasListas()
        {
            try
            {
                List<Compra> compras = new List<Compra>();
                string txtQuery = $"SELECT * FROM Compra_total WHERE estado = 'Listo'";

                SqlCommand comando = new SqlCommand(txtQuery, conexion);

                conexion.Open();

                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    compras.Add(new Compra(int.Parse(dataReader["id_compra"].ToString()), dataReader["cliente"].ToString(), (Compra.TipoEntrega)Enum.Parse(typeof(Compra.TipoEntrega), dataReader["tipo_entrega"].ToString()), dataReader["direccion"].ToString()));
                }

                return compras;
            }

            catch (Exception)
            {
                // crear excepcion de compras
                throw;
            }

            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Recupera los productos de la base de datos que tienen stock disponible
        /// </summary>
        /// <returns></returns>
        public static List<Producto> MostrarProductos()
        {
            try
            {
                List<Producto> productos = new List<Producto>();
                string txtQuery = $"SELECT * FROM Productos WHERE stock >= 1";

                SqlCommand comando = new SqlCommand(txtQuery, conexion);

                conexion.Open();

                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    productos.Add(new Producto(int.Parse(dataReader["id"].ToString()), dataReader["nombre"].ToString(), double.Parse(dataReader["precio"].ToString()), int.Parse(dataReader["stock"].ToString())));
                }

                return productos;
            }

            catch (Exception)
            {
                // crear excepcion de compras
                throw;
            }

            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Sube a la base de datos los datos de la compra - cabecera
        /// </summary>
        /// <param name="compraNueva"></param>
        /// <returns></returns>
        public static bool CargarCompraCabecera(Compra compraNueva)
        {
            try
            {
                string txtQuery = $"INSERT INTO Compra_total (total, direccion, cliente, tipo_entrega, estado) VALUES (@total, @direccion, @cliente, @tipo_entrega, @estado)";

                SqlCommand comando = new SqlCommand(txtQuery, conexion);

                comando.Parameters.AddWithValue("total", compraNueva.TotalCompra);
                comando.Parameters.AddWithValue("direccion", compraNueva.Direccion);
                comando.Parameters.AddWithValue("cliente", compraNueva.NombreCliente);
                comando.Parameters.AddWithValue("tipo_entrega", compraNueva.Entrega);
                comando.Parameters.AddWithValue("estado", compraNueva.Estado);

                conexion.Open();
                comando.ExecuteNonQuery();
                return true;
            }

            catch (Exception)
            {
                // crear excepcion de compras
                throw;
            }

            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Carga los productos de la compra en la tabla compra_detalle
        /// </summary>
        /// <returns></returns>
        public static void CargarCompraDetalle(List<Producto> productos)
        {
            try
            {
                int idCompra = MaximoIdBaseDatos();
                foreach (Producto prod in productos)
                {
                    string txtQuery = $"INSERT INTO Compra_detalle (id, producto, precio) VALUES (@id, @producto, @precio)";

                    SqlCommand comando = new SqlCommand(txtQuery, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("id", idCompra);
                    comando.Parameters.AddWithValue("producto", prod.Nombre);
                    comando.Parameters.AddWithValue("precio", prod.Precio);

                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }

            catch (Exception)
            {
                // crear excepcion de compras
                throw;
            }

            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }

        public static int MaximoIdBaseDatos()
        {
            try
            {
                int idCompra = -1;
                string txtQuery = $"SELECT MAX(id_compra) AS \"id_compra\" FROM compra_total";

                SqlCommand comando = new SqlCommand(txtQuery, conexion);

                conexion.Open();

                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    idCompra = int.Parse(dataReader["id_compra"].ToString());
                }

                return idCompra;
            }

            catch (Exception)
            {
                // crear excepcion de compras
                throw;
            }

            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }

        /// <summary>
        /// Actualiza el stock de los productos seleccionados por el usuario en la base de datos
        /// </summary>
        /// <param name="productos"></param>
        public static void RestarStock(List<Producto> productos)
        {
            try
            {
                foreach (Producto prod in productos)
                {
                    string txtQuery = $"UPDATE Productos SET stock = @stock WHERE id = @id";

                    int nuevoStock = prod.Stock - 1;

                    SqlCommand comando = new SqlCommand(txtQuery, conexion);
                    conexion.Open();

                    comando.Parameters.AddWithValue("stock", nuevoStock);
                    comando.Parameters.AddWithValue("id", prod.CodigoProducto);

                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }

            catch (Exception)
            {
                // crear excepcion de compras
                throw;
            }

            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
    