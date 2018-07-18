using System;
using System.Collections.Generic;

namespace MyDataStructureProject
{
    public class Program 
    {
        public static void Main(string[] args)
        {

        }
        /*
        public int IntegerSearch( arr, T find)
        {
            
            cSearch Binary = new cSearch();
            int result = Binary.SearchArray(arr, find);
            return result;
        }
<<<<<<< HEAD
        */
=======
        public int[] SortingG(int[] Arr)
        {
            int[] arr = Arr;
            var RequestSort = new Generic<int>();
            //Sorting Integer Value
            int[] sortedarr = RequestSort.SortingWithGeneric(arr);
            //Print value of sorted array
            foreach (int i in arr)
                Console.WriteLine(i);
            return arr;
        }
        //Integer Sorting
        public int[] IntegerSorting(int[] Arrr)
        {
            int[] arr = Arrr;
            CSort RequestSort = new CSort();
            //Sorting Integer Value
            int[] sortedarr = RequestSort.IntegerSort(arr);
            //Print value of sorted array
            foreach (int i in arr)
                Console.WriteLine(i);
            return arr;
        }
        //String Sorting
        public string[] StringSorting(String[] Arrr)
        {

            CSort RequestStringSort = new CSort();
            string[] SArr = Arrr;
            //Sorting String Value
            RequestStringSort.StringSort(SArr);
            //Print value of  sorted String 
            foreach (string s in SArr)
                Console.WriteLine(s);
            return SArr;
        }
        //Decimal Sorting
        public double[] DecimalSorting(double[] Arr)
        {
            CSort RequestDecimalSort = new CSort();
            double[] FArr = { 1.2, 5.50, 22, 5.6, 1.0 };
            //Sorting values of array
            RequestDecimalSort.DoubleSort(FArr);
            //Printing value of array
            foreach (double d in FArr)
                Console.WriteLine(d);
            return FArr;
        }

>>>>>>> 90a92869d29c7c8df5f3be73d42cd259ad10659d
    }
}