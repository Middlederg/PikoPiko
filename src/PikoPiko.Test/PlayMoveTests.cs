using System.Linq;
using Xunit;

namespace PikoPiko.Test
{
    public class PlayMoveTests
    {
        [Fact]
        public void Can_not_Save_previously_saved_results()
        {
            var move = new PlayMove();
            var firstResult = move.CurrentRoll.GetAllResults().First();

            move.Save(firstResult);

            do
            {
                move.Roll();
            }
            while (!move.CurrentRoll.Has(firstResult));

            var canBeSaved = move.CanSave(firstResult);
            
            Assert.False(canBeSaved);
            Assert.Throws<SavingResultException>(() => move.Save(firstResult));
        }

     
    }
}
