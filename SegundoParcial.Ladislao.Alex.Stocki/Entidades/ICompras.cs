using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public interface ICompras
    {
        bool AgregarProducto<C, P>(C c, P p)
            where C : Compra
            where P : Producto;

        bool QuitarProducto<C, P>(C c, P p)
            where C : Compra
            where P : Producto;
    }
}
