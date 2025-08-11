using System;
using System.IO;
using System.Linq.Expressions;
using LanguageExt.ClassInstances.Pred;

namespace ListApp
{

    public class Product
    {
        public string Name { get; set; }
        public double price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = 
                [
                "Red", 
                "Green", 
                "Blue", 
                "Green",
                ];
            colors.Add("Cyan");

            //List<string> colors = new List<string>();

            //colors.Add("Red");
            //colors.Add("Green");
            //colors.Add("Blue");
            //colors.Add("Green");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            colors.Remove("Green");
            

            
            bool isDeletingSuccessful = colors.Remove("Green");
            while (isDeletingSuccessful)
            {
                isDeletingSuccessful = colors.Remove("Green");
            }

            colors.Sort();
            Console.WriteLine("\nUpdated:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            List<int> numbers = new List<int> { 10, 1, 3, 29, 6, 4, 23, 20,25,15 };
            numbers.Add(9);
            numbers.Sort();
            Console.WriteLine("\nSort");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            List<int> higherOrEqualTen = numbers.FindAll(x => x >= 10);
            Console.WriteLine("\nHigher Or Equal Ten: ");
            foreach (int i in higherOrEqualTen)
            {  
                Console.WriteLine(i); 
            }

            //A lambda expression consists of 2 Parts
            //1.Parameters
            //2.Expression or Statement Block

            //Parameters are written on the left side of =>
            //(this symbol is read as "goes to" or "becomes").
            //The expression or action to perform is on the right side. 

            //This reads as:
            //"Take an input x and turn it into x multiplied by x. "
            // x => x * x;

            // Define the predicate to check if a number is greater than 10
            Predicate<int> GreaterThanTen = x => x > 10;


            List<Product> products = new List<Product>
            {
                new Product{Name = "Mango", price = .90},
                new Product{Name = "Apple", price = .70},
                new Product{Name = "Cherry", price = 1.80},

            };

            products.Add(new Product { Name = "Berries", price = 2.90 });

            Console.WriteLine("Available Products: ");

            foreach(Product product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} for {product.price} ");

            }

            List<Product> cheapProducts = products.Where(p => p.price < 1.0).ToList();


            Console.WriteLine("Available Products for less than $1: ");

            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product Name: {product.Name} for {product.price} ");

            }


            }
        }
}
