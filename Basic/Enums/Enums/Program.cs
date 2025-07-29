namespace Enums

{
    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 10, Aug, Sep, Oct, Nov, Dec  };
    internal class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fri;
            Day su = Day.Sun;

            Day a = Day.Fri;

            Console.WriteLine(fr == a);

            Console.WriteLine("Feb:" + (int)Month.Feb);
            Console.WriteLine("Jul:" + (int)Month.Jul);
            Console.WriteLine("Aug:" + (int)Month.Aug);
        }
    }
}
