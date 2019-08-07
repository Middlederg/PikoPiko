using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class Grill
    {
        public List<Ration> Rations { get; }

        public Grill()
        {
            Rations = RationFactory.GetRations().ToList();
        }

        public bool IsAvaliable(int number)
        {
            return Rations.Any(x => x.Value == number);
        }

        public Ration TakeRation(int number)
        {
            if (!IsAvaliable(number))
                throw new RationNotFoundException(number);

            var ration = Rations.Single(x => x.Value == number);
            Rations.Remove(ration);
            return ration;
        }

        public bool IsAvaliableBelow(int number)
        {
            return Rations.Any(x => x.Value < number - 1);
        }

        public Ration TakeRationBelow(int number)
        {
            if (!IsAvaliableBelow(number))
                throw new RationNotFoundException();

            var maxValue = Rations.Where(x => x.Value < number).Max(x => x.Value);
            var ration = Rations.Single(x => x.Value == maxValue);
            Rations.Remove(ration);
            return ration;
        }
    }
}
