using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes
{
    internal class Customer
    {   
        //ReadOnly Property
        private static int nextId = 0;
        private readonly int _id;

        //WriteOnly Property [No get method]
        private string _password;

        public string Password
        {
            set
            {
                _password = value;
            }
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public Customer(string name, string address = "N\\A", string contactNumber = "N\\A")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
        //public Customer(string name)
        //{
        //    Name = name;            
        //}
        public Customer()
        {
            _id = nextId++;
            Name = "New Customer";
            Address = "Unkown";
            ContactNumber = "Unkown";
        }

        // Default Paramter contactNumber
        public void SetDetai1s(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetaits(){
            Console.WriteLine($"Details about the customer: Name is {Name}" +
                $" and id is {_id}");
            }


    }
}
