using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Task_6__UI_
{
   public class SimpleDraw
    {
        public static Pen MyPen = new Pen(Color.Green, 4);
        public  int[] Arr { get; set; }
        public  int PanelWidth { get; set; }
        public  int PanelHeight { get; set; }
        public List<Bitmap> BitArr { get; set; }

        public SimpleDraw(int[] arr, int panelWidth, int panelHeight) // конструктор
        {
            PanelWidth = panelWidth;
            PanelHeight = panelHeight;
            BitArr = new List<Bitmap>();
            Arr = new int[arr.Length];
            Arr = arr;
        }

        public void BeginDraw()
        {
            BitArr.Add(DrawArrToBitmap());
            QuickSortRecursion(0, Arr.Length - 1);
            BitArr.Add(DrawArrToBitmap());
        }

        //        ElementArr[i].Inf = arr[i];
        //        ElementArr[i].ElementWidth = 40;
        //        ElementArr[i].ElementHeight = Arr[i] * 10 + 40;
        //        ElementArr[i].X = i* 40 + 40;
        //        ElementArr[i].Y = 300 + (540 - Arr[i] * 10 + 40);  поменять значение 300 чтобы опустить ниже рисунок   

        public Bitmap DrawArrToBitmap()//просто нарисовать без всего
        {
            Bitmap gBitmap = new Bitmap(PanelWidth, PanelHeight);
            Graphics gGraphics = Graphics.FromImage(gBitmap);
            gGraphics.Clear(Color.White);
            StringFormat centreNum = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            for (int i = 0; i < Arr.Length; i++)
            {
                Rectangle rl = new Rectangle(i * 40 + 40,
                    300 + (540 - Arr[i] * 10 + 40),
                    40,
                    Arr[i] * 10 + 40);
                Rectangle RlNumber = new Rectangle(i * 40 + 40,
                    300 + (540 - Arr[i] * 10 + 40),
                    40,
                    40);
                gGraphics.DrawRectangle(new Pen(Color.Black, 3), rl);
                gGraphics.DrawRectangle(new Pen(Color.Black, 3), RlNumber);
                gGraphics.DrawString(Arr[i].ToString(), SystemFonts.DefaultFont, Brushes.Black, RlNumber, centreNum);
            }
            gGraphics.Dispose();
            return gBitmap;
        }

        public Bitmap DrawArrToBitmapSort( int left, int right, int redElement)
        {    //нарисовать с границей сортировки и опорным элементом
            Bitmap gBitmap = new Bitmap(PanelWidth, PanelHeight);
            Graphics gGraphics = Graphics.FromImage(gBitmap);
            gGraphics.Clear(Color.White);
            StringFormat centreNum = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            gGraphics.FillRectangle(new SolidBrush(Color.LightGray), left * 40 + 40, 0, 40 * (right - left + 1),920);//границы сортировки
            gGraphics.FillRectangle(new SolidBrush(Color.Red), redElement * 40 + 40,
                300 + (540 - Arr[redElement] * 10 + 40),
            40, Arr[redElement] * 10 + 40);

            for (int i = 0; i < Arr.Length; i++)
            {
                Rectangle rl = new Rectangle(i * 40 + 40,
                    300 + (540 - Arr[i] * 10 + 40),
                    40,
                    Arr[i] * 10 + 40);
                Rectangle RlNumber = new Rectangle(i * 40 + 40,
                    300 + (540 - Arr[i] * 10 + 40),
                    40,
                    40);
                gGraphics.DrawRectangle(new Pen(Color.Black, 3), rl);
                gGraphics.DrawRectangle(new Pen(Color.Black, 3), RlNumber);
                gGraphics.DrawString(Arr[i].ToString(), SystemFonts.DefaultFont, Brushes.Black, RlNumber, centreNum);
            }

            gGraphics.Dispose();
            return gBitmap;
        }

        public void QuickSortRecursion(int left, int right)  // Рекурсивная
        {

            int i = left; int j = right;
            int x = Arr[(left + right) / 2]; // средний элемент
            int index = ((left + right) / 2);
            
            BitArr.Add(DrawArrToBitmapSort(i, j, index));
            //вызов границ

            do
            {
                while (Arr[i] < x)  // поиск элемента, большего среднего
                    i++;
                while (Arr[j] > x)  // поиск элемента, меньшего среднего
                    j--;

                //вызов стрелки
                Bitmap gBitmap = new Bitmap(PanelWidth, PanelHeight);
                gBitmap = BitArr[BitArr.Count - 1];
                Graphics gGraphics = Graphics.FromImage(gBitmap);
                gGraphics.DrawLine(MyPen, i * 40 + 40+20, 300 + (540 - Arr[i] * 10 + 40), i * 40 + 40+20, 150);
                gGraphics.DrawLine(MyPen, j * 40 + 40+20, 300 + (540 - Arr[j] * 10 + 40), j * 40 + 40+20, 150);
                gGraphics.DrawLine(MyPen, i * 40 + 40+20, 150, j * 40 + 40+20,150);
                BitArr.Add(gBitmap);
                gGraphics.Dispose();

                if (i <= j)         // обмен элементов местами
                {
                    //результат свапа

                    int tmp = Arr[i];
                    Arr[i] = Arr[j];
                    Arr[j] = tmp;
                    BitArr.Add(DrawArrToBitmapSort( i, j, index));
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
    }
}
