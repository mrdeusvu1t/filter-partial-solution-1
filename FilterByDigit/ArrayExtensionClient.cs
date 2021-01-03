using System;
using System.Collections.Generic;

namespace FilterByDigit
{
    public static partial class ArrayExtension
    {
        private static int _digit;
        public static int Digit
        {
            get { return _digit; }
            set
			{
                if (value < 0 || value > 9)
				{
                    throw new ArgumentOutOfRangeException(nameof(value));
				}

                _digit = value;
			}
        }
        
        static partial void AddAccordingToPredicate(ICollection<int> list, int item)
        {
            Digit = item;
        }
    }
}