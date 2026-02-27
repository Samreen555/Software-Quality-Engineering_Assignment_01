using System;

namespace SearchLibrary
{
    public class JumpSearch
    {
        public int Search(int key, int[] arr)
        {
            int n = arr.Length;
            int step = (int)Math.Sqrt(n);
            int prev = 0;

            while (prev < n && arr[Math.Min(step, n) - 1] < key)
            {
                prev = step;
                step += (int)Math.Sqrt(n);

                if (prev >= n)
                    return -1;
            }

            for (int i = prev; i < Math.Min(step, n); i++)
            {
                if (arr[i] == key)
                    return i;
            }

            return -1;
        }
    }
}