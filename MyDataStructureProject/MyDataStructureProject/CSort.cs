using System;
using System.Collections.Generic;


namespace MyDataStructureProject
{
    public class CSort<T>
    {
        public static int arr { get; set; }
        //Integer Sorting function
        public int[] IntegerSort(int[] arr)
        {
            int length = arr.Length;
            int temp = arr[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        //String Sorting function
        public string[] StringSort(string[] StrArr)
        {
            int len = StrArr.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    if (StrArr[j].CompareTo(StrArr[j + 1]) > 0)
                    {
                        String temp = StrArr[i];
                        StrArr[j] = StrArr[j + 1];
                        StrArr[j + 1] = temp;
                    }
                }
            }
            return StrArr;
        }
        //Decimal Sorting function
        public double[] DoubleSort(Double[] arr)
        {
            int length = arr.Length;
            double temp = arr[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        //sORTING WITH GENERICS
         public T[] SortingWithGenric(T[] arr)
        {
            int length = arr.Length;
           T temp = arr[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    Boolean IsGreater = false;
                    if(arr[i] is String )
                    {
                        IsGreater = String.Compare((arr[i] as string),(arr[j] as string))==1;
                    }
                    else
                    {
                        float x = float.Parse(arr[i].ToString());
                        float y = float.Parse(arr[j].ToString());

                        IsGreater = x > y;
                    }

                    if (IsGreater)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}


