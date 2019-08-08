namespace PikoPiko
{
    public class WormFirstPlay : BasePlay
    {
        public WormFirstPlay(int objective) : base(objective) { }

        protected override IResult Strategy()
        {
            if (move.CanSave(ResultFactory.Worm) && move.CurrentRoll.Has(ResultFactory.Worm))
                return ResultFactory.Worm;

            return Highest();
        }
    }
}
