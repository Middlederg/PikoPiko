namespace PikoPiko
{
    public class RandomPlay : BasePlay
    {
        public RandomPlay(int objective) : base(objective) { }

        protected override IResult Strategy()
        {
            IResult result;
            do
            {
                result = ResultFactory.Any;
            }
            while (!move.CanSave(result) || !move.CurrentRoll.Has(result));
            return result;
        }
    }
}
