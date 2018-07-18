using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructureProject
{
    public class cSearchWithList
    {
        public int SearchArray(List<int> arr, int find)
        {           
            for(int i= 0; i< arr.Count; i++)
            {
                if (arr[i].Equals(find))
                    return i;
            }
            return -1;
        }
    }
}
