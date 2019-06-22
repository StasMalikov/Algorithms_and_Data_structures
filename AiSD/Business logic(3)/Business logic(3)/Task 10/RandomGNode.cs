using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_logic_3_
{
    public class RandomGNode
    {
        public static List<NodeGraph> SetNotes()
        {
            List<NodeGraph> List = new List<NodeGraph>();
            int[][] arr1 ={new int[] {0,200}, new int[] {700,850}};
            int[][] arr2 = { new int[] { 300, 400}};
            int[][] arr3 = { new int[] { 400, 600 }};
            int[][] arr4 = { new int[] { 200, 700 } };
            int[][] arr5 = { new int[] { 0, 300 }, new int[] {600,800 } };

            NodeGraph n1 = new NodeGraph(1, arr1);
            NodeGraph n2 = new NodeGraph(2, arr2);
            NodeGraph n3 = new NodeGraph(3, arr3);
            NodeGraph n4 = new NodeGraph(4, arr4);
            NodeGraph n5 = new NodeGraph(5, arr5);
            
            List.Add(n1);
            List.Add(n2);
            List.Add(n3);
            List.Add(n4);
            List.Add(n5);

            return List;
        }

    }
}
