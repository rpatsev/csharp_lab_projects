namespace BubbleSort
{
    public class MyBubbleSort
    {
        public static void BubbleSort(int[] myArray)
        {
            int temp;
            int counter = 0;
            for(int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if (myArray[j] > myArray[j+1])
                    {
                        temp = myArray[j+1];
                        myArray[j+1] = myArray[j];
                        myArray[j] = temp;
                        
                    }
                    counter++;
                }
            }
        }
    }
}
