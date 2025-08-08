namespace DateTimeFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2002, 7, 23);

            Console.WriteLine("My Birthday:" + date);


            Console.WriteLine("Today: {0}", DateTime.Today);

            Console.WriteLine("Now: {0}", DateTime.Now);

            DateTime tomorrow = getTomorrow();

            Console.WriteLine("Tomorrow: " + tomorrow);

            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);

            Console.WriteLine("First day of the year: " + getFirstDayOfYear(2002));

            int days = DateTime.DaysInMonth(2002, 7);
            Console.WriteLine("Days in Jul, 2002: {0}", days);

            days = DateTime.DaysInMonth(2003, 2);
            Console.WriteLine("Days in Feb, 2003: {0}", days);

            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb, 2004: {0}", days);

            DateTime now = DateTime.Now;

            Console.WriteLine("minute: " + now.Minute);

            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Enter your birthday in YYYY-MM_DD format: ");

            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime dateTime))
            {
                Console.WriteLine(dateTime);

                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Your are {0} days old!", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }

        static DateTime getTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        
        static DateTime getFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
