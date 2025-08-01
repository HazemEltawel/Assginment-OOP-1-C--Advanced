using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_OOP_1_C__Advanced
{
    public class implements
    {
         public static void OptimizedBubbleSort (int[] arr)
        { 
            int n = arr.Length;
            bool swapp;
            for (int i = 0; i < n - 1; i++)
            {
                swapp = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapp = true;

                    }
                }
                if (!swapp)
                {
                    break;
                }
            }
        }














    }
}
