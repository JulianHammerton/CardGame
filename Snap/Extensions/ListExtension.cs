using System;
using System.Collections.Generic;

namespace ListExtension
{
    static class ListExtension
    {
        private static readonly Random random = new Random();

        public static T Pop<T>(this List<T> list)
        {
            T poppedObject = list[0];
            list.RemoveAt(0);
            return poppedObject;
        }

        public static T RemoveRandom<T>(this List<T> list)
        {
            var randomLocation = random.Next(list.Count);
            T selectedCard = list[randomLocation];
            list.RemoveAt(randomLocation);
            return selectedCard;
        }
    }
}
