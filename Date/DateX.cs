namespace Date
{
    /// <summary>
    /// Class to calculate DateDiff between two DateTime objects. Just for fun
    /// </summary>
    public class DateX
    {
        private static readonly int[] numOfDays = { 1, 32, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335,365 };
        private static readonly int[] numOfDaysLeap = { 1, 32, 61, 92, 122, 153, 183, 214, 245, 275, 306, 336,366 };
        public int GetDateDiff(DateTime date1, DateTime date2)
        {

            var daysDiff = DaysDiff(date1, date2);
            if (date1.Year == date2.Year)
            {

                return daysDiff;
            }
            else
            {

                var totalYears = date2.Year - date1.Year;
                var negative = totalYears < 0;
                var minYear = date1.Year;
                var maxYear = date2.Year;
                var totalDays = 0;
                if (negative)
                {
                    totalYears *= -1;
                    daysDiff *= -1;
                    minYear = date2.Year;
                    maxYear = date1.Year;
                }

                for (; minYear < maxYear; minYear++)
                {
                    totalDays+=IsLeapYear(minYear) ? numOfDaysLeap[12] : numOfDays[12];
                }

                
                var diff = negative ? (totalDays + daysDiff) * -1 : totalDays + daysDiff;
                return diff;
            }

        }

        public int GetDayOfTheYear(DateTime date)
        {
            if (IsLeapYear(date.Year))
            {
                return numOfDaysLeap[date.Month - 1] + date.Day - 1;
            }
            else
            {
                return numOfDays[date.Month - 1] + date.Day - 1;
            }
        }


        public bool IsLeapYear(int year)
        {
            return year % 4 == 0;
        }

        private int DaysDiff(DateTime date1, DateTime date2)
        {
            return GetDayOfTheYear(date2) - GetDayOfTheYear(date1);
        }

    }
}