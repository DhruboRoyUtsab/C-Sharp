using System.Security.Cryptography;

namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];

                
            }
            
            Console.WriteLine($"Average temperature: {CalculateAverageTemp(temperature)} ");
            Console.WriteLine($"The Max temperature: {temperature.Max()}");
            Console.WriteLine($"The Min temperature: {temperature.Min()}");
            Console.WriteLine($"The Most Common Condition: {MostCommonCondition(weatherConditions)}");
        }

        static string MostCommonCondition(string[] condition)
        {
            int count = 0;
            string mostCommon = condition[0];
            for (int i = 0; i < condition.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < condition.Length; j++)
                {
                if (condition[j] == condition[i])
                    {
                        tempCount++;
                    }
                    
                }
                count = tempCount;
                mostCommon = condition[i];

            }
            return mostCommon;
        }
        static double CalculateAverageTemp(int[] temperature)
        {
            double sum = 0;
            for (int i = 0; i < temperature.Length; i++)  
            {
                sum += temperature[i];
            }
            double average = sum / temperature.Length;
            return average;
        }
    }
}
