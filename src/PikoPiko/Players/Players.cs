using System;
using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class Players
    {
        private readonly Turn turn;
        public List<Player> PlayerList { get; }
        public Player CurrentPlayer => PlayerList[turn.CurrentTurn];
        public int PlayerCount => PlayerList.Count;
        public int CurrentTurn => turn.CurrentTurn;
        public Player GetPlayer(int indx)
        {
            if (indx >= PlayerCount)
                throw new ArgumentOutOfRangeException(nameof(indx));
            return PlayerList[indx];
        }

        public Players(IEnumerable<Player> players)
        {
            this.PlayerList = players.ToList();
            turn = new Turn(players.Count());
        }

        public Players(params Player[] players) : this(players.ToList()) { }

        public IEnumerable<Player> Others => PlayerList.Where(x => !x.Equals(CurrentPlayer));

        public void Next() => turn.Next();
        public bool OtherPlayerHasVisibleRation(int number) => Others.Any(x => x.HasVisibleRation(number));

        public void RemoveRationFromOtherPlayer(int number)
        {
            if(!OtherPlayerHasVisibleRation(number))
                throw new RationNotFoundException(number);

            var stolenRation = PlayerList.First(x => x.HasVisibleRation(number)).Remove();
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
        public IEnumerable<Player> Ranking() => PlayerList.OrderByDescending(x => x.Worms()).ThenByDescending(x => x.MaxValue()).ToList();
    }
}
