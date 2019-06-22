using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace Business_logic_3_
{
    public class Recursion_1
    {
        public List<string> Lines = new List<string>();
        public List<string> numbersforLines = new List<string>();

        public int RecurtionSumm(int n, int first)
        {
            if (n < 3)
                return 0;
            numbersforLines.Add(Convert.ToString(first));
            int result = 0;
            if (first < n - 1)
            {
                ++result;
                Print(n - 1, first);
                result += recursion(n - 1, first + 1);
                numbersforLines.Clear();
                result += RecurtionSumm(n - 1, first + 1);
            }            
            return result;
        }
        public int recursion(int n, int first)
        {
            int result = 0;
            numbersforLines.Add(Convert.ToString(first));
            if (n > first)
            {
                ++result;
                print(n - first, first);
                result += recursion(n - first, first + 1);
            }
            return result;
        }
        public void print(int n, int first)
        {
            string str = "";
            for (int i = 0; i < 2; ++i)
            {
                str += " ";
            }
            for (int i = 0; i < numbersforLines.Count; ++i)
            {
                str += numbersforLines[i];
                str += " + ";
            }
            str += Convert.ToString(n);
            Lines.Add(str);
        }
        public void Print(int n, int first)
        {
            string str = "";
            str += Convert.ToString(first);
            str += " + ";
            str += Convert.ToString(n);
            Lines.Add(str);
        }
    }
}
