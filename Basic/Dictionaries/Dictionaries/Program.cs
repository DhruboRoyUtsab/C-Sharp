namespace Dictionaries
{
    internal class Program
    {

        class Employee
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public int Salary { get; set; }

            public Employee(string name, int age, int salary)
            {
                Name = name;
                Age = age;
                Salary = salary;

            }

        }
        static void Main(string[] args)
        {

            //Key - value


            Dictionary<int, string> employees = new Dictionary<int, string>();

            //Adding
            employees.Add(101, "Utsab");
            employees.Add(102, "Dhrubo");
            employees.Add(103, "Bishal");
            employees.Add(104, "Sokal");
            employees.Add(105, "Shakib");

            string name = employees[101];
            Console.WriteLine(name);

            //Updating
            employees[102] = "Dhrubo Roy";

            //Removing
            employees.Remove(105);

            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }
            if (!employees.ContainsKey(104))
            {
                employees.Add(104, "Saadman");
            }

            int counter = 101;

            while (employees.ContainsKey(counter))
            {
                counter++;
            }
            employees.Add(counter, "Siam");

            bool added = employees.TryAdd(103, "Bishal Kumar");
            if (!added)
            {
                Console.WriteLine("Employee already exists with that ID.");
            }


            //object 
            Dictionary<int, Employee> Emp = new Dictionary<int, Employee>();

            Emp.Add(1, new Employee("Utsab", 23, 100000));
            Emp.Add(2, new Employee("Dhrubo", 24, 80000));
            Emp.Add(3, new Employee("John", 22, 50000));

            foreach (var item in Emp)
            {
                Console.WriteLine($"ID: {item.Key}, Name: {item.Value.Name} " +
                    $"earns {item.Value.Salary} " +
                    $"and is {item.Value.Age} years old!");
            }


            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };
            if (codes.TryGetValue("NY", out string state)){
                Console.WriteLine(state);

            }
            foreach (var item in codes)
            {
                Console.WriteLine($"Statecode: {item.Key} & State name: {item.Value}");
            }


        }
    }
}
