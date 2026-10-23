using System;
using System.Collections.Generic;

namespace DSA.Lab01
{
    public static class SortAlgorithms
    {
        public static void InsertionSort(int[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            // TODO: Sort the array in ascending order using insertion sort.
            //
            // Think of values[0..i-1] as the already-sorted part.
            // For each next value:
            // 1. Store the value you want to insert.
            // 2. Shift larger values one position to the right.
            // 3. Put the stored value into the gap.

            for (int i = 1; i < values.Length; i++)
            {
                int valueToSort = values[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    int valueAt = values[j];

                    if (valueToSort < valueAt)
                    {
                        values[j + 1] = valueAt;
                    
                        if (j == 0)
                        {
                            values[j] = valueToSort;
                            break;
                        }
                    }
                    else
                    {
                        values[j + 1] = valueToSort;
                        break;
                    }
                }
            }
        }
    }
}
