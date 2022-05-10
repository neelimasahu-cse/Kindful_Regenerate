using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MulitipleViews
{
    internal class SaveXML
    {
        public static void savedata(Object obj, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, obj);
            writer.Close();

        }
    }
}
