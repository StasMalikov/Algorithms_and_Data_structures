using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace Business_logic_3_
{ 
   public class Combine_elements
    {
       public List<Work_with_Files> List{get; set;}
       public Combine_elements(List<Work_with_Files> list)
       {
           List = list;
       }
       public int[] SummArrs()
       {
           int[] resultArr = new int[List[0].IntLines.Count * 3];
           for (int i = 0, j = 0; j < List[0].IntLines.Count; i = i + 3, ++j)
           {
               resultArr[i] =List[0].IntLines[j];
               resultArr[i + 1] = List[1].IntLines[j];
               resultArr[i + 2] = List[2].IntLines[j];
           }
           return resultArr;
       }
    }
}
