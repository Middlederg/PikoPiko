using System;
using System.Collections.Generic;
using System.Text;

namespace PikoPiko.Test
{
    public static class ObjectFactory
    {
        public static Player AnyPlayer => new Player("Tomás");
        public static Players AnyTwoPlayers => new Players(new Player("Ana"), new Player("Belén"));
        public static Players AnyThreePlayers => new Players(new Player("Tomás"), new Player("Ana"), new Player("Belén"));
        public static GameContext TwoPlayerGame => new GameContext("Ana", "Belén");
    }
}
