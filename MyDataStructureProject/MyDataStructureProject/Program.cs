using System;

namespace MyDataStructureProject
{
    public class Program
    {
        public static void Main(string[] args)
        {

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
        public double[] DecimalSorting()
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

    }
}

