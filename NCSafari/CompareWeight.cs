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
        // I can call the CompareWeight in descending order like-> animalsToSee.Sort(new CompareWeight(true));
        // or ascending order -> animalsToSee.Sort(new CompareWeight(false));
        public int Compare(Animal? x, Animal? y)
        {
            // next 3 lines handle null references so the program doesn't crash
            if (x == null && y == null) return 0; // if both are null, they are equal
            if (x == null) return -1; // if x is null, put it at the start
            if (y == null) return 1; // if y is null, put it at the end

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
