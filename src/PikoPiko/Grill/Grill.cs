using System;
using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class Grill
    {
        private List<Ration> rations;
        protected List<Ration> Rations => rations.Where(x => x.IsActive).ToList();
        public IEnumerable<Ration> GetRations() => Rations.OrderBy(x => x.Value);
        
        public bool HasRations => Rations.Any(x => x.IsActive);
        private Ration HighestRation
        {
            get
            {
                if (!Rations.Any())
                    return null;

                var maxValue = Rations.Max(x => x.Value);
                return Rations.Single(x => x.Value == maxValue);
            }
        }

        public Grill()
        {
            rations = RationFactory.GetRations().ToList();
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
            rations.Remove(ration);
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
            rations.Remove(ration);
            return ration;
        }

        public bool IsLowerThanHighestRation(Ration ration)
        {
            if (!HasRations)
                return false;
            return ration.Value < HighestRation.Value;
        }

        internal void InsertRation(Ration ration)
        {
            rations.Insert(0, ration);
        }

        public void TurnDownHighestRation()
        {
            if (!HasRations)
                throw new RationNotFoundException();

            HighestRation.TurnDown();
        }
    }
}
