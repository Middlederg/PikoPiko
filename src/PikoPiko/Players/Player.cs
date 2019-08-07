using System;
using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class Player
    {
        private Guid id;

        private List<Ration> rations;
        public bool HasRations => rations.Any();
        public bool HasVisibleRation(int number) => HasRations && VisibleRation.Value == number;
        public Ration VisibleRation => HasRations ? rations.Last() : null;
        public void AddRation(Ration ration) => rations.Add(ration);
        public Ration Remove()
        {
            if (!HasRations)
                throw new RationNotFoundException();

            var rationToRemove = rations.Last();
            rations.Remove(rationToRemove);
            return rationToRemove;
        }

        public Player()
        {
            id = Guid.NewGuid();
            rations = new List<Ration>();
        }

        public int Worms() => HasRations ? rations.Sum(x => x.Worms) : 0;
        public int MaxValue() => HasRations ? rations.Max(x => x.Value) : 0;

        public override string ToString() => $"Player {id.ToString()}";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((Player)obj).id == id;
        }

        public override int GetHashCode() => id.GetHashCode();
    }
}
