using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            try 
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                TextWriter w = new StreamWriter(archivo);
                s.Serialize(w, datos);
                w.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                TextReader r = new StreamReader(archivo);
                datos = (T)s.Deserialize(r);
                r.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
