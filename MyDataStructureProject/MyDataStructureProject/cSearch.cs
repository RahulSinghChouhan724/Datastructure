﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructureProject
{
    public class cSearch <T>
    {
        public static T arr { get; set; }

        public int SearchArray(T[] arr, T find)
        {           
            for(int i= 0; i< arr.Length; i++)
            {
                if (arr[i].Equals(find))
                    return i;
            }
            return -1;
        }
    }
}
