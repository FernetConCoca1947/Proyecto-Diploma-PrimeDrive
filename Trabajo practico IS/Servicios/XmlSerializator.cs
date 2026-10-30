using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Servicios
{
    public abstract class AbstractSerializator<T>
    {
        public abstract string Serializar(T objeto, string rutaArchivo);
        public abstract T Deserializar(Stream str);
    }

    public class XmlSerializator<T> : AbstractSerializator<T>
    {
        // 1. SERIALIZAR: Guarda el estado del objeto en un archivo físico .xml
        public override string Serializar(T que, string rutaArchivo)
        {
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, que);
                return fs.Name;
            }
        }

        // 2. DESERIALIZAR: Lee el archivo .xml y reconstruye la instancia en memoria
        public override T Deserializar(Stream str)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader tr = new StreamReader(str))
            {
                return (T)serializer.Deserialize(tr);
            }
        }
    }
}
