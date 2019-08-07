using System;

namespace PikoPiko
{
    public class Turn
    {
        public const int MaxPlayerNumber = 10;
        private readonly int playerCount;

        public int CurrentTurn { get; private set; }
        public void SetTurn(int value) => CurrentTurn = value;

        public Turn(int playerCount)
        {
            if (playerCount < 1 || playerCount > MaxPlayerNumber)
                throw new ArgumentOutOfRangeException($"{nameof(playerCount)} should be between {1} and {MaxPlayerNumber}");

            this.playerCount = playerCount;
            CurrentTurn = ResultFactory.GetRandomNumber(playerCount - 1);
        }

        public void Next() => CurrentTurn = playerCount - 1 == CurrentTurn ? 0 : CurrentTurn + 1;
    }
}
