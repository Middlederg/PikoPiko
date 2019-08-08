namespace PikoPiko
{
    public abstract class BasePlay
    {
        protected readonly PlayMove move;
        protected readonly int objective;
        public int Points => move.Points;

        public BasePlay(int objective)
        {
            this.objective = objective;
            move = new PlayMove();
        }

        public void Play()
        {
            do
            {
                IResult result = Strategy();

                move.Save(result);
                move.Roll();
            }
            while (move.CanKeepRolling() && move.IsFailure(objective));
        }

        protected abstract IResult Strategy();
    }
}
