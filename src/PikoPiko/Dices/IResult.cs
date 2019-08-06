namespace PikoPiko
{
    public interface IResult : IPath
    {
        int Value { get; }
        bool IsWorm { get; }
    }
}
