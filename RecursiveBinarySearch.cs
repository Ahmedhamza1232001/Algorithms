namespace Algorithms
{
    public class RecursiveBinarySearch

    {
        public static int Search(int[] sortedArray ,int low , int high, int key)
        {
            if (low <= high)
            {
                int mid = (low+high)/2;
                if (sortedArray[mid] == key)
                {
                    return mid;
                }
                if(sortedArray[mid] < key)
                {
                    return Search(sortedArray, mid+1, high, key);    
                }
                
                
                return Search(sortedArray,low,mid-1,key);
                
                  
            }
            return -1;
        }
    }
}
