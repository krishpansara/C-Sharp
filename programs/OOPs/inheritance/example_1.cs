using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs.inheritance
{
    class Vehicle
    {
        string color;
        int prize, avg;

        public Vehicle(int prize, int avg)
        {
            this.avg = avg;
            this.prize = prize;

        }

        public void showVehicle()
        {
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Prize : " + prize);

        }
    }

    class Car : Vehicle
    {

        string transmision, brand_name, model_name;


        public Car(string brand_name, string model_name, int prize, int avg, string transmision) : base(prize, avg)
        {
            this.model_name = model_name;
            this.brand_name = brand_name;
            this.transmision = transmision;
        }

        public void showCar()
        {

            Console.WriteLine("Brand Name " + brand_name);
            Console.WriteLine("Model Name " + model_name);
            Console.WriteLine("Transmission : " + transmision);

        }

    }
    internal class example_1
    {
        public static void Main()
        {
            Car c1 = new Car("Sujuki", "Auto", 80000, 50,    "Manual");
            c1.showCar();
            c1.showVehicle();
        }
    }
}
