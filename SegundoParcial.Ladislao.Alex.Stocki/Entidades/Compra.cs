using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Compra : ICompras
    {
        #region Atributos
        private List<Producto> productos;
        private string direccion;
        private int numeroCompra;
        private string nombreCliente;
        private TipoEntrega entrega;
        private EstadoPedido estado;

        #endregion
        
        #region Propiedades
        public List<Producto> Productos
        {
            get { return this.productos; }
        }

        public string NombreCliente
        {
            get { return this.nombreCliente; }
            set { this.nombreCliente = value; }
        }

        public int NumeroCompra
        {
            get { return this.numeroCompra; }
            set { this.numeroCompra = value; }
        }

        public string Entrega
        {
            get { return this.entrega.ToString(); }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public string Estado
        {
            get { return this.EstadoToDB(); }
        }

        public double TotalCompra
        {
            get { return this.MontoTotal(); }
        }
        #endregion

        #region Constructores
        public Compra()
        {
            this.productos = new List<Producto>();
            this.Direccion = string.Empty;
            this.estado = EstadoPedido.EnPreparacion;
        }

        public Compra(string nombreCliente, TipoEntrega tipoEntrega)
            : this()
        {
            this.NombreCliente = nombreCliente;
            this.entrega = tipoEntrega;
        }

        public Compra(string nombreCliente, TipoEntrega tipoEntrega, string direccion)
            : this(nombreCliente, tipoEntrega)
        {
            this.Direccion = direccion;
        }

        public Compra(int numeroCompra, string nombreCliente, TipoEntrega tipoEntrega)
            : this(nombreCliente, tipoEntrega)
        {
            this.NumeroCompra = numeroCompra;
        }

        public Compra(int numeroCompra, string nombreCliente, TipoEntrega tipoEntrega, string direccion)
            : this(numeroCompra, nombreCliente, tipoEntrega)
        {
            this.Direccion = direccion;
        }
        #endregion

        #region Operadores/Metodos
        public static Compra operator +(Compra c, Producto p)
        {
            if (!(c is null) && !(p is null))
            {
                c.productos.Add(p);
                return c;
            }
            return c;
        }

        public static bool operator ==(Compra c, Producto p)
        {
            foreach (Producto prod in c.Productos)
            {
                if (prod == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Compra c, Producto p)
        {
            return !(c == p);
        }

        bool ICompras.AgregarProducto<C, P>(C c, P p)
        {
            c.Productos.Add(p);
            return true;
        }

        bool ICompras.QuitarProducto<C, P>(C c, P p)
        {
            if ((Compra)c == (Producto)p)
            {
                c.Productos.Remove(p);
                return true;
            }
            return false;
        }

        private double MontoTotal()
        {
            double monto = 0;

            foreach (Producto p in this.Productos)
            {
                monto += p.Precio;
            }

            return monto;
        }

        private string EstadoToDB()
        {
            string retornoEstado = string.Empty;
            if (this.estado == EstadoPedido.EnPreparacion)
            {
                retornoEstado = "En Preparacion";
            }
            else
            {
                retornoEstado = "Listo";
            }
            return retornoEstado;
        }
        #endregion

        public enum TipoEntrega
        {
            Local,
            Delivery
        }

        public enum EstadoPedido
        {
            EnPreparacion,
            Listo
        }
    }
}
