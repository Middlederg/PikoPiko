using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class Players
    {
        private Turn turn;
        private List<Player> players;
        public Player CurrentPlayer => players[turn.CurrentTurn];

        public Players(int playerCount)
        {
            players = Enumerable.Range(0, playerCount)
                .Select(x => new Player()).ToList();
            turn = new Turn(playerCount);
        }

        private IEnumerable<Player> Others => players.Where(x => !x.Equals(CurrentPlayer));

        public void Next() => turn.Next();
        public bool OtherPlayerHasVisibleRation(int number) => Others.Any(x => x.HasVisibleRation(number));

        public void RemoveRationFromOtherPlayer(int number)
        {
            if(!OtherPlayerHasVisibleRation(number))
                throw new RationNotFoundException(number);

            var stolenRation = players.First(x => x.HasVisibleRation(number)).Remove();
            CurrentPlayer.AddRation(stolenRation);
        }

        public Ration RemoveVisibleRationFromCurrentPlayer()
        {
            if (!CurrentPlayer.HasRations)
                return null;

            var ration = CurrentPlayer.Remove();
            return ration;
        }

        public Player Winner() => Ranking().First();
        public IEnumerable<Player> Ranking() => players.OrderByDescending(x => x.Worms()).ThenByDescending(x => x.MaxValue()).ToList();
    }
}
