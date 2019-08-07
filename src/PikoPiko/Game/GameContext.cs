using System.Collections.Generic;

namespace PikoPiko
{
    public class GameContext
    {
        private Grill grill;
        private Players players;
        public Player CurrentPlayer => players.CurrentPlayer;
        
        public GameContext(int playerCount)
        {
            grill = new Grill();
            players = new Players(playerCount);            
        }

        public bool IsSuccess(int number)
        {
            if (grill.IsAvaliable(number))
                return true;

            if (players.OtherPlayerHasVisibleRation(number))
                return true;

            if (grill.IsAvaliableBelow(number))
                return true;

            return false;
        }

        public void TakeRation(int number)
        {
            if (grill.IsAvaliable(number))
            {
                var ration = grill.TakeRation(number);
                players.CurrentPlayer.AddRation(ration);
            }
            else
            {
                if (players.OtherPlayerHasVisibleRation(number))
                {
                    players.RemoveRationFromOtherPlayer(number);
                }
                else
                {
                    if (grill.IsAvaliableBelow(number))
                    {
                        var ration = grill.TakeRationBelow(number);
                        CurrentPlayer.AddRation(ration);
                    }
                    else
                    {
                        throw new RationNotFoundException(number);
                    }
                }
            }
            players.Next();
        }

        public void LoseRation()
        {
            if (CurrentPlayer.HasRations)
                MoveRationFromCurrentPlayerToGrill();

            players.Next();
        }

        private void MoveRationFromCurrentPlayerToGrill()
        {
            var ration = players.RemoveVisibleRationFromCurrentPlayer();

            if (grill.IsLowerThanHighestRation(ration))
                grill.TurnDownHighestRation();

            grill.InsertRation(ration);
        }

        public bool IsEndOfGame() => !grill.HasRations;        

        public Player Winner() => players.Winner();
        public IEnumerable<Player> Ranking() => players.Ranking();
    }
}
