using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructureProject
{
   public class Generic<T>
    {

        public static T arr { get; set; }
        //sORTING WITH GENERICS
        public T[] SortingWithGeneric(T[] arr)
        {
            int length = arr.Length;
            T temp = arr[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    Boolean IsGreater = false;
                    if (arr[i] is String)
                    {
                        IsGreater = String.Compare((arr[i] as string), (arr[j] as string)) == 1;
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
