using System;
namespace MergeSort
{
    public static class Sort
    {
        public static T[] MergeSort<T>(T[] unsortData) where T : IComparable
        {
            int length = unsortData.Length;
            if (length <= 1) return unsortData;

            int leftSize = length / 2;
            int rightSize = length - leftSize;
            T[] left, right, result;

            left = new T[leftSize];
            right = new T[rightSize];

            for (int i = 0; i < leftSize; i++)
                left[i] = unsortData[i];
            for (int i = 0; i < rightSize; i++)
                right[i] = unsortData[i + leftSize];

            left = MergeSort(left);
            right = MergeSort(right);

            result = new T[length];

            int lIndex = 0, rIndex = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (lIndex >= left.Length)
                {
                    result[i] = right[rIndex];
                    rIndex++;
                }
                else if (rIndex >= right.Length)
                {
                    result[i] = left[lIndex];
                    lIndex++;
                }
                else if (left[lIndex].CompareTo(right[rIndex]) <= 0)
                {
                    result[i] = left[lIndex];
                    lIndex++;
                }
                else
                {
                    result[i] = right[rIndex];
                    rIndex++;
                }
            }

            return result;
        }
    }
}
