using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace PantallaDePedidos
{
    public partial class FormPedidos : Form
    {
        Thread pedidosEnPreparacion;
        Thread pedidosListos;
        Thread productosLista;
        List<Producto> carrito;
        Compra compra;
        public FormPedidos()
        {
            InitializeComponent();
            productosLista = new Thread(this.MostrarProductos);
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            this.CargarPedidos();
            //this.MostrarProductos();
            carrito = new List<Producto>();
            this.cbTipoEntrega.DataSource = Enum.GetValues(typeof(Compra.TipoEntrega));
            try
            {
                while (true)
                {
                    if (productosLista.IsAlive)
                    {
                        productosLista.Abort();
                        productosLista.Start();
                    }
                    else
                    {
                        productosLista.Start();
                        Thread.Sleep(4000);
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (productosLista.IsAlive)
                {
                    productosLista.Abort();
                }
            }
        }

        /// <summary>
        /// Carga los dgv de las compras En Preparacion y Listas
        /// </summary>
        private void CargarPedidos()
        {
            
            this.dgvPedidosEnPreparacion.DataSource = SistemaDAO.MostrarComprasNoListas();
            this.dgvPedidosListos.DataSource = SistemaDAO.MostrarComprasListas();
        }

        /// <summary>
        /// dvg del menu de productos
        /// </summary>
        private void MostrarProductos()
        {
            this.dgvProductos.DataSource = SistemaDAO.MostrarProductos();
        }

        private void Carrito()
        {

        }

        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ingresa el producto seleccionado en el carrito del pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAlPedido_Click(object sender, EventArgs e)
        {
            int id = (int)dgvProductos.CurrentRow.Cells["CodigoProducto"].Value;
            string nombre = (string)dgvProductos.CurrentRow.Cells["Nombre"].Value;
            double precio = (double)dgvProductos.CurrentRow.Cells["Precio"].Value;
            int stock = (int)dgvProductos.CurrentRow.Cells["Stock"].Value;

            try
            {
                carrito.Add(new Producto(id, nombre, precio, stock));
            }
            catch (Exception exp)
            {

            }
        }

        /// <summary>
        /// Toma los productos seleccionados y arma una compra
        /// que se almacena en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(this.txtboxNombreCliente.Text == string.Empty))
                {
                    if (this.cbTipoEntrega.Text == "Local")
                    {
                        compra = new Compra(this.txtboxNombreCliente.Text, (Compra.TipoEntrega)Enum.Parse(typeof(Compra.TipoEntrega), this.cbTipoEntrega.Text));
                    }
                    else
                    {
                        if (!(this.txtboxDireccion.Text == string.Empty))
                        {
                            compra = new Compra(this.txtboxNombreCliente.Text, (Compra.TipoEntrega)Enum.Parse(typeof(Compra.TipoEntrega), this.cbTipoEntrega.Text), this.txtboxDireccion.Text);
                        }
                        else
                        {
                            throw new PedidoException("Se requiere una direccion para los pedidos delivery");
                        }
                    }
                }
                else
                {
                    throw new PedidoException("Se requiere un nombre de cliente para todos los pedidos");
                }

                compra = this.ArmarCompra(this.compra, this.carrito);
                SistemaDAO.RestarStock(carrito);
                SistemaDAO.CargarCompraCabecera(compra);
                //SistemaDAO.CargarCompraDetalle(compra.Productos);
                MessageBox.Show("Pedido agregado exitosamente");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Informacion faltante");
            }
            finally
            {
                compra = null;
            }
        }

        /// <summary>
        /// Ingresa todos los productos del carrito en una compra
        /// </summary>
        /// <param name="c"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        private Compra ArmarCompra(Compra c, List<Producto> ps)
        {
            foreach (Producto producto in ps)
            {
                c += producto;
            }
            return c;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPedidoNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
