using System;

namespace Pair
{
    public sealed class Pair<T, U>
    {
        public static Pair<T, U> MakePair(T first, U second)
        {
            Pair<T, U> ReturnValue = new Pair<T, U>
            {
                First = first,
                Second = second
            };

            return ReturnValue;
        }

        public override string ToString() => First.ToString() + " - " + Second.ToString();

        public T First { get; set; }
        public U Second { get; set; }
    }
}
