namespace PikoPiko
{
    public class CleverPlay : BasePlay
    {
        public CleverPlay(int objective) : base(objective) { }

        protected override IResult Strategy()
        {
            if (move.CanSave(ResultFactory.Worm) && move.CurrentRoll.Has(ResultFactory.Worm) && move.CurrentRoll.WormCount > 1)
                return ResultFactory.Worm;

            return Best();
        }
    }
}
