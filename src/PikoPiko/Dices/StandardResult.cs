namespace PikoPiko
{
    public abstract class StandardResult : IResult
    {
        public abstract int Value { get; }
        public bool IsWorm => false;
        public string ImagePath => $"result_{Value}";

        public override string ToString() => Value.ToString();

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((IResult)obj).Value == Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
