namespace PikoPiko
{
    public class Ration : IPath
    {
        public int Value { get; }
        public int Worms { get; }

        private bool active;
        public bool IsActive => active;
        public void TurnDown() => active = false;

        public Ration(int value, int worms)
        {
            Value = value;
            Worms = worms;
            active = true;
        }

        public string ImagePath => $"worms_{Worms}" ;

        public override string ToString() => $"{Value} ({Worms} worm{(Worms != 1 ? "s" : "")})";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((Ration)obj).Value == Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
