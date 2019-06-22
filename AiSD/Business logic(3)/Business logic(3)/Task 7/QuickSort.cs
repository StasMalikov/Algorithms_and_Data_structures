using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_logic_3_
{
    public class ArrSort
    {
        public int[] Arr { get; set; }

        public ArrSort(int[] arr)
        {
            Arr = new int[arr.Length];
            Arr = arr;
        }
        public void sort()
        {
            QuickSortRecursion(0, Arr.Length-1);
        }

        public void QuickSortRecursion(int left, int right)  
        {
            int i = left; int j = right;
            int x = Arr[(left + right) / 2]; // средний элемент
            do
            {
                while (Arr[i] < x)  // поиск элемента, большего среднего
                    i++;
                while (Arr[j] > x)  // поиск элемента, меньшего среднего
                    j--;

                if (i <= j)         // обмен элементов местами
                {
                    int tmp = Arr[i];
                    Arr[i] = Arr[j];
                    Arr[j] = tmp;
                    i++;
                    j--;                   
                }
            }
            while (i <= j);

            if (left < j)
                QuickSortRecursion(left, j);   // обработка левого подмассива
            if (i < right)
                QuickSortRecursion(i, right);  // обработка правого подмассива
        }
        public static int[]  SetRandomArr(int num)
        {
            int[] Arr = new int[num]; 
            Random r = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = r.Next(50);
            }
            return Arr;
        }
    }
}
