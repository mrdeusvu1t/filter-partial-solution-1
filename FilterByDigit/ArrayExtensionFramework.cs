﻿using System;

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
            throw  new NotImplementedException();
        }

        //TODO: Add parameters to the method if necessary.
        static partial void AddAccordingToPredicate();
    }
}