using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory.Models
{
    public class Vehicle
    {
         public string Name { get; set; }
         public string Model { get; set; }
         public string CarType { get; set; }
         public int HorsePower { get; set; }
        public decimal Price { get; set; }

        public void AddVehicle()
        {
            Console.WriteLine($"Nazwa: {this.Name}\n" +
                $"Model: {this.Model}\n" +
                $"Typ nadwozia: {this.CarType}\n" +
                $"Moc silnika: {this.HorsePower} km\n" +
                $"Cena: {this.Price} zł");
        }
    }
}
