﻿using System;
using System.Collections.Generic;

namespace PikoPiko
{
    public static class ResultFactory
    {
        private static readonly Random r = new Random();
        public static IResult Any => GetResult(r.Next(1, 7));
        public static int GetRandomNumber(int until) => r.Next(0, until + 1);
        public static int GetRandomNumber(int from, int until) => r.Next(from, until + 1);
        public static IEnumerable<IResult> AllResults => new List<IResult>() { One, Two, Three, Four, Five, Worm };
        public static IResult GetResult(int number)
        {
            switch (number)
            {
                case 1: return One;
                case 2: return Two;
                case 3: return Three;
                case 4: return Four;
                case 5: return Five;
                case 6: return Worm;
                default:
                    throw new NotImplementedException();
            }
        }

        public static One One => new One();
        public static Two Two => new Two();
        public static Three Three => new Three();
        public static Four Four => new Four();
        public static Five Five => new Five();
        public static WormResult Worm => new WormResult();
    }
}
