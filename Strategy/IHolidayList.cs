using System.Collections.Generic;

namespace Strategy
{
    public interface IHolidayList
    {
        HashSet<string> GetHolidays();
    }
}
