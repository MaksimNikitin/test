using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new UnitesStatesHolidayList());
            var result = client.CheckForHoliday("04.09");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
