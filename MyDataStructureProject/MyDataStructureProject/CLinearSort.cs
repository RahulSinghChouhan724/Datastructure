using System;

namespace MyDataStructureProject
{
    public class CSort
    {

        public static class Sort
        {
            public static string arr { get; set; }

        }

        public  int[] GetArr(int[] arr)
        {

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;

                    }
                    else
                    {
                        int temp = arr[min_idx];
                        arr[min_idx] = arr[i];
                        arr[i] = temp;
                    }
                }

            }
            return arr;

        }
    }
}


