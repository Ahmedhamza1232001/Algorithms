using System;
namespace Algorithms
{
    public class SelectionSort
    {
        public static int[] Sort(int[]  unsortedArray)
        {
            
            for (int i = 0 ; i <  unsortedArray.Length; i++)
			{
                int minValue = unsortedArray[i];
                int temp = i;
                for (int m = i+1 ; m < unsortedArray.Length-1 ; m++)
			    {
                
                if (minValue> unsortedArray[m])
                    {
                    minValue = unsortedArray[m];
                    temp = m;
                    }
	
			    }

                
                unsortedArray[temp] = unsortedArray[i];
                unsortedArray[i] = minValue;
                
			}
            return unsortedArray;
        }  

    }
}
