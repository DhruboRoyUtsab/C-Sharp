namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car BMW = new Car("I7","BMW", true);
            Car Audi = new Car("A3", "Audi", false);
            Console.WriteLine("Please enter the brand Name:");


            //Audi.Brand = Console.ReadLine();

            Console.WriteLine("Brand: " + Audi.Brand);
            Console.WriteLine("Brand: " + BMW.Brand);
            
            Car Audi = new Car("A3", "Audi", false);
            Car BMW = new Car("I7", "BMW", true);
            Audi.Drive();
            BMW.Drive();
            */

            //Customer Alex = new Customer("Alex");
            //Console.WriteLine($"Name: {Alex.Name}");

            Customer Frank = new Customer("Frank", "Mainstreet", "23123123");
            Console.WriteLine($"Name: {Frank.Name}, Address: {Frank.Address} and ContactNumber: {Frank.ContactNumber}");

            Customer myCustomer = new Customer("Denis");
            Console.WriteLine("ContactNumber: " + myCustomer.ContactNumber);

            Frank.GetDetaits();
            myCustomer.GetDetaits();
            //Customer Anonymous = new Customer();


            //Anonymous.Name = Console.ReadLine();
            //Console.WriteLine($"Name: {Anonymous.Name}");

            
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3","Audi", false);
            Console.WriteLine($"Number of Cars {Car.NumberOfCars}");
            
            Console.ReadKey();
        }
    }
}
