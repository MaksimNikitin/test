using System.Collections.Generic;

namespace Strategy
{
    class BelarusHolidayList : IHolidayList
    {
        public HashSet<string> GetHolidays()
        {
            return new HashSet<string>
            {
                "01.01",
                "07.01",
                "08.03",
                "01.05",
                "09.05",
                "03.07",
                "25.12"
            };
        }
    }
}
