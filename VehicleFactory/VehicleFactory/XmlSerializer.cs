using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using VehicleFactory.Models;

namespace VehicleFactory
{
    public class DataXmlSerializer<T>
    {
        public static void SerializeData(T vehicle, string filename)
        {
            var serializer = new XmlSerializer(vehicle.GetType());
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, vehicle);
            writer.Close();
        }
    }
}
