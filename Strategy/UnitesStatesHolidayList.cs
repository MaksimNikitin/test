using System.Collections.Generic;


namespace Strategy
{
    class UnitesStatesHolidayList : IHolidayList
    {
        public HashSet<string> GetHolidays()
        {
            return new HashSet<string>
            {
                "01.01",
                "02.01",
                "16.01",
                "20.02",
                "29.05",
                "04.07",
                "04.09",
                "09.10",
                "11.11",
                "23.11",
                "25.12"
            };
        }
    }
}
