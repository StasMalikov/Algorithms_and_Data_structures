using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_logic_3_
{
    public class Recursion
    {
        public List<string> Lines { get; set; }
        

        //public  int number=0;
        
        public  int RecurtionSumm(int n,int first,int number)
        {
            if (first < n-1)
            {
                //Print(n - 1,first,number);
                ++number;
                number=RecurtionSumm(n - 1, first+1 ,number);
            }
            return number;
        }
        public void Print(int n, int first,int number)
        {
            this.Lines[number] += Convert.ToString(first);
            this.Lines[number] += " + ";
            this.Lines[number] += Convert.ToString(n);
        }
    }
}
