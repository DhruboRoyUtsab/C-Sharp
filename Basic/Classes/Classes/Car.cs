using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        public static int NumberOfCars = 0;
         
        //Member variable
        //private string _model = "";
        private string _brand = "";
        private bool _isLuxury;


        //Property [Encapsulate field and uses lamda expression]
        //public string Model { get => _model; set => _model = value; }
        public string Model { get; set; }
        public string Brand
        {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered Nothing!");
                    _brand = "Default Value";
                }
                else
                {
                    _brand = value;
                }
            }
        }

        public bool IsLuxury {
            get => _isLuxury;
            set => _isLuxury = value;
        }

        public Car(string model, string brand, bool isLuxury) {
            NumberOfCars++;
            Brand = brand;
            Model = model;
            Console.WriteLine($"A {Brand} of the model " +
                $"{Model} has been created.");
            IsLuxury = isLuxury;
            
        }
        public Car()
        {
            NumberOfCars++;
            
        }


        public void Drive()
        {
            Console.WriteLine($"Im driving a {Model}");
        }
    }
}
