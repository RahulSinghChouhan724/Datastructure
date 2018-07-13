using System;

namespace MyDataStructureProject
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            //Integer Sorting
            int[] arr = { 11, 55, 1, 13, 55, 66, 2 };
            CSort RequestSort = new CSort();
            //Sorting Integer Value
            int[] sortedArr = RequestSort.IntegerSort(arr);
            //Print value of sorted array
            foreach (int i in sortedArr)
                Console.WriteLine(i);

            //String Sorting
            string[] SArr = {"j","a","f","e","r"};
            //Sorting String Value
            RequestSort.StringSort(SArr);
            //Print value of  sorted String 
            foreach (string s in SArr)
                Console.WriteLine(s);

            //Decimal Sorting
            double[] FArr = {1.2,5.50,22,5.6,1.0};
            //Sorting values of array
            RequestSort.DoubleSort(FArr);
            //Printing value of array
            foreach (double d in FArr)
                Console.WriteLine(d);



            Console.ReadLine();
        }
    }
}
