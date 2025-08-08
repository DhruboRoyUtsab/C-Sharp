using System.Diagnostics;

namespace TryCatchExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            try
            {
                Console.WriteLine("Please enter a number: ");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = 10;

                result = num2 / num1;

            }
            catch(FormatException ex) 
            {
                Console.WriteLine(ex.Message + "Please enter a number!");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Number TOO HIGH!");
            }
            //Mother Excpetion //Must Include
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

                // This next line is only_executed during "Debugging"
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("This always Execute");
            }

            Console.WriteLine("Result: " + result);
            Console.WriteLine("Enter Age: ");
            GetUserAge(Console.ReadLine());

        }

        static int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age.");

            }
            if (age < 0 || age > 120)
            {
                throw new Exception("Your age must be between O and 120.");
            }
            return age;
        }
    }
}
