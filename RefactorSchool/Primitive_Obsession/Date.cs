namespace RefactorSchool.Primitive_Obsession
{
    class Date
    {
        public int Month { get; set; }
        public int Day { get; set; }

        public Date(int day, int month)
        {
            Day = day;
            Month = month;
        }
    }
}