using System;

namespace RefactorSchool.Primitive_Obsession
{
    class DateInYear
    {
        public Guid Id { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }
        public string Description { get; private set; }

        public DateInYear(int month, int day, string description)
        {
            Id = Guid.NewGuid();
            SetMonth(month);
            SetDay(day);
            Description = description;
        }

        public void SetMonth(int month)
        {
            if (month > 12)
            {
                throw new ArgumentException("Month value cannot be grater than 12");
            }

            if (Month == month)
            {
                return;
            }

            Month = month;
        }

        public void SetDay(int day)
        {
            // ;)
            if (day > 31)
            {
                throw new ArgumentException("Day value cannot be grater than 31");
            }

            if (Day == day)
            {
                return;
            }

            Day = day;
        }

    }
}