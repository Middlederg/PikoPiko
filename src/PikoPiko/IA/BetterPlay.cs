namespace PikoPiko
{
    public class BetterPlay : BasePlay
    {
        public BetterPlay(int objective) : base(objective) { }

        protected override IResult Strategy()
        {
            if (move.CanSave(ResultFactory.Worm) && move.CurrentRoll.Has(ResultFactory.Worm))
                return ResultFactory.Worm;

            return move.CurrentRoll.Higest().Result;
        }
    }
}
