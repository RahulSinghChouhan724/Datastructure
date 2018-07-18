using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructureProject
{
    public class cSearch <T>
    {
        public static T arr { get; set; }

<<<<<<< HEAD
        public int SearchArray(T[] arr, T find)
        {           
            for(int i= 0; i< arr.Length; i++)
            {
                if (arr[i].Equals(find))
                    return i;
=======
        public int SearchArray(int[] arr, int find)
        {
            //SortING the array Before Searching
            Program Sort = new Program();
            int[] Sarr = Sort.IntegerSorting(arr);
            //Searching
            int i = 0, j;
            int found = 0;
            j = Sarr.Length;

            while (i <= j)
            {

                if (Sarr[(i + j) / 2] == find)
                {
                    found = (i + j) / 2;
                    return found;
                }
                else if (Sarr[(i + j) / 2] < find)
                    i = ((i + j) / 2) + 1;
                else
                    j = ((i + j) / 2) - 1;
>>>>>>> 90a92869d29c7c8df5f3be73d42cd259ad10659d
            }
            return -1;
        }
    }
}
