using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BubbleSort : Strategy
    {
        
        public void Sort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for(int j = 0; j < arr.Length-1-i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = tmp;
                    }
                }
            }
        }

      
    }
}
