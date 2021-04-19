using System;
using System.Collections.Generic;

namespace Marcware.BulkyConvert.ExtensionMethods
{
    internal static class CollectionExtensionMethods
    {
        /// <summary>
        /// Returns the item number of the item that is closest to the value specified.
        /// For example: [10, 20, 30, 40], value 31 will return 2
        /// </summary>
        /// <param name="items"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int GetNearestItemNumber(this IEnumerable<double> items, double value)
        {
            int itemNo = 0;
            double nearestValue = 10000000;
            int nearestItem = 0;
            foreach (double item in items)
            {
                double diffference = Math.Abs(item - value);
                if (diffference < nearestValue)
                {
                    nearestItem = itemNo;
                    nearestValue = diffference;
                }
                itemNo++;
            }
            return nearestItem;
        }
    }
}
