namespace Strategy
{
    public class Client
    {
        private readonly IHolidayList _hollidayListStrategy;

        public Client(IHolidayList strategy)
        {
            _hollidayListStrategy = strategy;
        }

        public bool CheckForHoliday(string date)
        {
            return _hollidayListStrategy.GetHolidays().Contains(date);
        }
    }
}
