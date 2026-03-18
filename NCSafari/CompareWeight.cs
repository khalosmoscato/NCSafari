using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal class CompareWeight : IComparer<Animal>
    {
        public bool IsDescending { get; set; }
        public CompareWeight(bool isDescending)
        {
            IsDescending = isDescending;
        }

        public int Compare(Animal? x, Animal? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            if (x.WeightInKg > y.WeightInKg)
            {
                if (IsDescending) // if descending is true
                {
                    return -1; // heavier first
                }
                else
                {
                    return 1; // heavier last
                }
            }
            else if (x.WeightInKg < y.WeightInKg)
            {
                if (IsDescending) // in this case we have a mirror effect of what happens above
                {
                    return 1; // lighter last
                }
                else
                {
                    return -1; // lighter first
                }
            }
            return 0;
        }
    }
}
