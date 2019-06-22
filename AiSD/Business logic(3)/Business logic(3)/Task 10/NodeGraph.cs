using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_logic_3_
{
    public class NodeGraph
    { 
        public string Name { get; set; }
        public int Num { get; set; }
        public int[][] WorkTime { get; set; }
        public List<int> Time { get; set; }
        public int[][] Coordinates { get; set; }

        public NodeGraph(int num, int[][] arr)
        {
            Name += "Сторож ";
            Name += num.ToString();
            Num = num;
            WorkTime = arr;
            Time = new List<int>();
            Coordinates = new int[arr.Length][];
            for (int i = 0; i < WorkTime.Length; i++)
            {
                Time.Add(WorkTime[i][1] - WorkTime[i][0]);
            }
            for (int i = 0; i < WorkTime.Length; i++)
            {
                Coordinates[i] = new int[4];
            }
        }
    }
}
