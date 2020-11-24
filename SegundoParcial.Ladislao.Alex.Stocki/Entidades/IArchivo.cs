using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public interface IArchivo<T>
    {
        bool Guardar(string archivos, T datos);

        bool Leer(string archivo, out T datos);
    }
}
