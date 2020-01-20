using System;
using System.Linq;
using System.Collections.Generic;

namespace LinkA
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 11, 15, 8, 1, 22 };
            int target = 23;
            //int i, j = 0;

            int[] answer = TwoSum(array, target);
            foreach (var i in answer)
            {
                Console.WriteLine(i);
            }
            
        }
         public static int[] TwoSum(int[] array, int target)
        {

            Dictionary<int, int> PrevNumber = new Dictionary<int, int>();
            for (int i =0; i<array.Length;i++)
            {
               int  complement = target - array[i];
               
                if (PrevNumber.ContainsKey(complement))
                {
                    return new int[] { PrevNumber[complement], i };
                }
                PrevNumber.Add(array[i], i);
            }
            return null;
        }
    }

    
}
