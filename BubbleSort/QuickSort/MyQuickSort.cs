namespace QuickSort
{
    public class MyQuickSort
    {
        public static void QuickSort(int[] array, int low, int high)
        {
            if(low < high)
            {
                
                int p = Partition(array, low, high);
                QuickSort(array, low, p-1);
                QuickSort(array, p + 1, high);

            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            for(int j = low; j <= high - 1; j++)
            {
                if(array[j] < pivot)
                {
                    i++;
                    int temp = array[j];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            int t = array[high];
            array[high] = array[i + 1];
            array[i + 1] = t;
            return i + 1;
        }


    }
}
