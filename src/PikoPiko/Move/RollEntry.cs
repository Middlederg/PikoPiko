namespace PikoPiko
{
    public class RollEntry
    {
        public IResult Result { get; }
        public int Quantity { get; }

        public RollEntry(IResult result, int quantity)
        {
            Result = result;
            Quantity = quantity;
        }

        public int Points() => Result.Value * Quantity;

        public override string ToString() => $"{Result.ToString()}: {Quantity}";
    }
}
