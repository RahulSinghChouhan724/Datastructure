using System;

namespace MyDataStructureProject
{
    public class Program
    {
        CSort csort = new CSort();
       public static void Main(string[] args)
        {
            int []arr = {11,55,1,13,55,66,2};
            int[] sortint = csort.GetArr(arr);
        }
    }
}
