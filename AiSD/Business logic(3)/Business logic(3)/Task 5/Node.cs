using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_logic_3_
{
    public class Node     // Узел для списка, стека, очереди
    {
        public int Inf { get; set; }
        public Node Next { get; set; }
        public Node(int inf, Node next)            
        {
            this.Inf = inf;
            this.Next = next;
        }
    }
}
