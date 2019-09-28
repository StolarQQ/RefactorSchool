using System;

namespace RefactorSchool.Temporal_Coupling
{
    public class BakeGood : BakedGoodBase
    {
        public void MakeBakeGood()
        {
            MakeBakeTemplate();
        }

        protected override void PrepareCrust()
        {
            Console.WriteLine("PrepareCrust");
        }

        protected override void AddToppings()
        {
            Console.WriteLine("AddToppings");
        }

        protected override void Bake()
        {
            Console.WriteLine("Bake");
        }

        protected override void CutIntoSlices()
        {
            Console.WriteLine("CutIntoSlices");
            Console.WriteLine("Good job, bake is done !");
        }
    }
}