using System;

namespace Entidades
{
    public class Producto
    {
        #region Atributos
        private string nombre;
        private double precio;
        private int codigoProducto;
        private int stock;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int CodigoProducto
        {
            get { return this.codigoProducto; }
            set { this.codigoProducto = value; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }
        #endregion

        #region Metodos
        public Producto()
        {

        }

        public Producto(int codigoProducto, string nombre, double precio, int stock)
        {
            this.CodigoProducto = codigoProducto;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Dos productos son iguales si su codigo de producto es el mismo
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>True si son iguales.
        /// False caso contrario.</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.CodigoProducto == p2.CodigoProducto)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Dos productos son distintos si su codigo de producto es distinto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>True si son distintos. False caso contrario.</returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
