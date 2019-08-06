using System;

namespace PikoPiko
{
    public class WormResult : IResult
    {
        public const int WormDefaultValue = 5;

        public int Value => WormDefaultValue;
        public bool IsWorm => true;
        public string ImagePath => "worm";

        public override string ToString() => $"Worm ({Value})";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((IResult)obj).IsWorm;
        }

        public override int GetHashCode() => (WormDefaultValue + 1).GetHashCode();
    }
}
