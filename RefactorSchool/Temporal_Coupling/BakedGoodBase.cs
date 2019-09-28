namespace RefactorSchool
{
    public abstract class BakedGoodBase
    {
        public void MakeBakeTemplate()
        {
            PrepareCrust();
            AddToppings();
            Bake();
            CutIntoSlices();
        }

        protected abstract void PrepareCrust();
        protected abstract void AddToppings();
        protected abstract void Bake();
        protected abstract void CutIntoSlices();
    }
}