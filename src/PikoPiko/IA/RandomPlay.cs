namespace PikoPiko
{
    public class RandomPlay : BasePlay
    {
        public RandomPlay(int objective) : base(objective) { }

        protected override IResult Strategy()
        {
            return Highest();
        }
    }
}
