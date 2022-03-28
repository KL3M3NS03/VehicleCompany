using System;
using System.IO;
using VehicleFactory.Models;
using static System.Xml.Serialization.XmlSerializer;

namespace VehicleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle = new Vehicle();
            //Console.WriteLine("Podaj nazwę: ");
            //var name = Console.ReadLine();
            //vehicle.Name = name;
            //Console.Clear();
            //Console.WriteLine("Podaj model: ");
            //var model = Console.ReadLine();
            //vehicle.Model = model;
            //Console.Clear();
            //Console.WriteLine("Podaj typ: ");
            //var type = Console.ReadLine();
            //vehicle.CarType = type;
            //Console.Clear();
            //Console.WriteLine("Podaj moc: ");
            //var power = Console.ReadLine();
            //vehicle.HorsePower = int.Parse(power);
            //Console.Clear();
            //Console.WriteLine("Podaj cenę: ");
            //var price = Console.ReadLine();
            //vehicle.Price = decimal.Parse(price);
            //Console.Clear();
            //vehicle.AddVehicle();
            Console.WriteLine(":");
            var filename = Console.ReadLine();
            Console.Clear();
            var filepath = Path.Combine(@"C:\Users\uczen\source\repos\VehicleFactory\VehicleFactory\Data\", filename);
            //DataXmlSerializer<Vehicle>.SerializeData(vehicle, filepath);
            XmlDeserializer.DataDeserialize(filepath);
        }
    }
}
