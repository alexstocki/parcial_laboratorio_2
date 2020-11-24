using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class PedidoException : Exception
    {
        public PedidoException(string mensaje)
            : base(mensaje)
        {
                
        }
    }
}
