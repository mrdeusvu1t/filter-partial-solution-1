using System;
using System.Collections.Generic;

namespace FilterByDigit
{
    public static partial class ArrayExtension
    {
        /// <summary>
        /// Returns new array of elements that satisfy some predicate.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>New array of elements that satisfy some predicate.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int[] FilterByPredicate(this int[] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
			{
                throw new ArgumentException("array is empty");
			}

            List<int> newArray = new List<int>();

            for (int i = 0; i < source.Length; i++)
            {
                if ((source[i] == int.MinValue || source[i] == int.MaxValue) && Digit == 0)
                {
                    continue;
                }

                if (source[i] == int.MinValue && Digit != 5)
                {
                    newArray.Add(source[i]);
                    continue;
                }

                var temp = Math.Abs(source[i]);
                do
                {
                    if (temp % 10 == Digit)
                    {
                        newArray.Add(source[i]);
                        break;
                    }

                    temp /= 10;
                }
                while (temp != 0);
            }

            return newArray.ToArray();
        }

        static partial void AddAccordingToPredicate(ICollection<int> list, int item);
    }
}