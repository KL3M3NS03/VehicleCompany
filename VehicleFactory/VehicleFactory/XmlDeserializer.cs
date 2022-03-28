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
    public class XmlDeserializer
    {
        public static void DataDeserialize(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Vehicle));
            FileStream fs = new FileStream(filename , FileMode.Open);
            Vehicle vehicle;
            vehicle = (Vehicle)serializer.Deserialize(fs);
            Console.WriteLine($"Nazwa: {vehicle.Name}\n" +
                $"Model: {vehicle.Name}\n" +
                $"Typ nadwozia: {vehicle.CarType}\n" +
                $"Moc silnika: {vehicle.HorsePower} km\n" +
                $"Cena: {vehicle.HorsePower} zł");
        }
    }
}
