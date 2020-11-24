using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ArchivosException : Exception
    {
        public ArchivosException() : base("Error con el archivo")
        {

        }

        public ArchivosException(Exception innerException) 
            : base(innerException.Message, innerException)
        {

        }

        public ArchivosException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }
    }
}
