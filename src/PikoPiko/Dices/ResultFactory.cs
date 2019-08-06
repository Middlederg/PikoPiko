using System;

namespace PikoPiko
{
    public static class ResultFactory
    {
        private static Random r = new Random();
        public static IResult GetRandomResult() => GetResult(r.Next(1, 7));

        public static IResult GetResult(int number)
        {
            switch (number)
            {
                case 1: return new One();
                case 2: return new Two();
                case 3: return new Three();
                case 4: return new Four();
                case 5: return new Five();
                case 6: return new WormResult();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
