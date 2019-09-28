using System.Collections.Generic;
using RefactorSchool.Primitive_Obsession;
using RefactorSchool.Temporal_Coupling;

namespace RefactorSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StatmentCodeSmell
            
            // Primitive Obsession

            //BAD
            HolidayStore.AddBadHoliday(7, 4);
            var badIndependenceDay = new Date(7, 4);

            //GOOD
            var independenceDay = new DateInYear(month: 7, day: 4, description: "IndependenceDay");
            var christmasDay = new DateInYear(month: 12, day: 23, description: "Christmas");

            HolidayStore.AddHoliday(independenceDay);
            HolidayStore.AddHoliday(christmasDay);

            // Vertical Separation
            // Variables and function should be defined close to where they are used.

            // Poor Names

            var z = 10;
            var x = new List<int>();
            for (var i = 0; i < z; i++)
            {
                for (var j = 0; j < z - 1; j++)
                {
                    x.Add(j);
                }
            }
            
            // Switch statement repeat

            // Duplicate code

            // Dead code
            
            // Temporal coupling

            var goodBake = new BakeGood();
            goodBake.MakeBakeTemplate();

            #endregion

            // Design patterns - mediator, command, strategy, factory, builder
        }
    }
}
