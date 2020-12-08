using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace You_Source._Model
{
    public class Model
    {
    
        public string SortingMethod { get; set; }

        public String StringValue { get; set; }
       private const string QuickSortMethod = "QuickSort";


        public String SorrtArray()
        {
           
            if (string.IsNullOrEmpty(StringValue)){
                
                MessageBox.Show("Invalid string value, Please try again", "Error");
            }
           
                if (SortingMethod.Equals(QuickSortMethod)){
                    return GetQuickSort(StringValue);
                }
                else{
                    return GetBubbleSort(StringValue);
                }
        }

        private char[] ConvertString(String StringValue)
        {
            return StringValue.ToLower().ToArray();
        }

        public String GetBubbleSort(String StringValue)
        {
            char[] arr = ConvertString(StringValue);
            BubbleSort(arr);
            return new string(arr);
        }
        public String GetQuickSort(String StringValue)
        {
            char[] arr = ConvertString(StringValue);
            QuickSort(arr, 0, arr.Length - 1);
            return new string(arr);
        }
        private void BubbleSort(char[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        char temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        private static void QuickSort(char[] arr, int left, int right)
        {
            if (left < right)
            {

                int pi = Partition(arr, left, right);

                QuickSort(arr, left, pi - 1);
                QuickSort(arr, pi + 1, right);
            }
        }
        private static int Partition(char[] arr, int left,
                                 int right)
        {
            int pivot = arr[right];


            int x = (left - 1);
            for (int i = left; i < right; i++)
            {

                if (arr[i] < pivot)
                {
                    x++;


                    char temp = arr[x];
                    arr[x] = arr[i];
                    arr[i] = temp;
                }
            }


            char temp1 = arr[x + 1];
            arr[x + 1] = arr[right];
            arr[right] = temp1;

            return ++x;
        }


    }
  }