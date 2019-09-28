using System;
using System.Collections.Generic;

namespace RefactorSchool.Primitive_Obsession
{
    internal static class HolidayStore
    {
        private static ISet<DateInYear> _holidayDates = new HashSet<DateInYear>();
        public static IEnumerable<DateInYear> HolidayDates => _holidayDates;
        public static void AddHoliday(DateInYear date)
        {
            _holidayDates.Add(date);
        }

        public static void AddBadHoliday(int i, int i1)
        {
            // Just bad example of code
            throw new NotImplementedException();
        }
    }
}