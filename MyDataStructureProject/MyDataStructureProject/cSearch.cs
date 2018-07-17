using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructureProject
{
    class cSearch
    {
        public static int arr { get; set; }

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
            }
            return -1;
        }
    }
}


