namespace Algorithms
{
    public class BinarySearch
    {
        
        public static int Search(int[] myArray, int myKey)
        {
            int Low = 0;
            int High = myArray.Length - 1;
            int Mid; //what lenght do we need

            while (Low < High)
            {
                Mid = (Low + High) / 2;

                if (myKey == myArray[Mid]) //best case 
                    return Mid;

                if (myKey < myArray[Mid])
                    High = Mid - 1;

                else 
                    Low = Mid + 1;

            }
            return -1;

        }
    



    }

}
