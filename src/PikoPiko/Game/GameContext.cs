using System;
using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class GameContext
    {
        public Grill Grill { get; }
        public Players Players { get; }
        public Player CurrentPlayer => Players.CurrentPlayer;

        public int MinimunObjetive
        {
            get
            {
                var grillMinValue = RationFactory.RationCount + RationFactory.RationFirstValue + 1;
                var playersMinValue = grillMinValue;

                if (Grill.HasRations)
                    grillMinValue = Grill.GetRations().Min(x => x.Value);

                var visibleRations = Players.Others
                    .Where(x => x.HasRations)
                    .Select(x => x.VisibleRation);
                if (visibleRations.Any())
                    playersMinValue =  visibleRations.Min(x => x.Value);

                return Math.Min(grillMinValue, playersMinValue);
            }
        }

        public GameContext(IEnumerable<string> names)
        {
            Grill = new Grill();
            Players = new Players(names.Select(name => new Player(name)));            
        }

        public GameContext(params string[] names) : this(names.ToList()) { }

        public bool IsSuccess(int number)
        {
            if (Grill.IsAvaliable(number))
                return true;

            if (Players.OtherPlayerHasVisibleRation(number))
                return true;

            if (Grill.IsAvaliableBelow(number))
                return true;

            return false;
        }

        public void TakeRation(int number)
        {
            if (Grill.IsAvaliable(number))
            {
                var ration = Grill.TakeRation(number);
                Players.CurrentPlayer.AddRation(ration);
            }
            else
            {
                if (Players.OtherPlayerHasVisibleRation(number))
                {
                    Players.RemoveRationFromOtherPlayer(number);
                }
                else
                {
                    if (Grill.IsAvaliableBelow(number))
                    {
                        var ration = Grill.TakeRationBelow(number);
                        CurrentPlayer.AddRation(ration);
                    }
                    else
                    {
                        throw new RationNotFoundException(number);
                    }
                }
            }
            Players.Next();
        }

        public void LoseRation()
        {
            if (CurrentPlayer.HasRations)
                MoveRationFromCurrentPlayerToGrill();

            Players.Next();
        }

        private void MoveRationFromCurrentPlayerToGrill()
        {
            var ration = Players.RemoveVisibleRationFromCurrentPlayer();

            if (Grill.IsLowerThanHighestRation(ration))
                Grill.TurnDownHighestRation();

            Grill.InsertRation(ration);
        }

        public bool IsEndOfGame() => !Grill.HasRations;        

        public Player Winner() => Players.Winner();
        public IEnumerable<Player> Ranking() => Players.Ranking();
    }
}
