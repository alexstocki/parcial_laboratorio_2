using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, Compra compra)
        {
            try
            {
                StreamWriter sw = new StreamWriter(archivo);
                sw.WriteLine($"Direccion: {compra.Direccion}\nCliente: {compra.NombreCliente}\tTotal: ${compra.TotalCompra}");
                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Leer(string archivo, out string datos)
        {
            try
            {
                StreamReader sr = new StreamReader(archivo);
                datos = sr.ReadToEnd();
                sr.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;

            try
            {
                StreamWriter sw = new StreamWriter(archivo);

                sw.WriteLine(datos);

                sw.Close();

                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

            return retorno;
        }
    }
}
