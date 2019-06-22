using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;
using Business_logic_3_;

namespace Task_5
{
   public class MyQueue
    {
        public Node Head { get; set; }                          
        public Node Tail { get; set; }
        public int Count { get; set; }                     // число элементов

        public MyQueue()
        {
            Head = null; 
            Tail = null; 
            Count = 0;
        }

        public MyQueue DeleteNegative(MyQueue Q,Node a,Node b)
        {
            if (b != null)
            {
                if (b.Inf >= 0)   // pozitive
                {
                    if(b.Next!=null)
                    DeleteNegative(Q, b, b.Next);
                }
                if (b.Inf < 0)  //negative 
                {
                    if (b == Q.Head)// proverka na head
                    {
                        Q.Head = Q.Head.Next;
                        DeleteNegative(Q, Q.Head, Q.Head.Next);
                    }
                    if (b == Q.Tail) // proverka na tail
                    {
                        Q.Tail = a;
                        return Q;
                    }
                    a.Next = find(b);
                    DeleteNegative(Q, a, a.Next);
                }
            }
                return Q;
        }
        Node find(Node a)
        {
            if (a != null)
            {
                if (a.Inf >= 0)
                {
                    return a;
                }
                else
                {
                    find(a.Next);
                }
            }
            return null;
        }

        public  MyQueue Delete(MyQueue Q)
        {
            return DeleteNegative(Q, Q.Head, Q.Head); 
        }

        public bool QueueIsEmpty()              // проверка на пустоту
        {
            return Head == null;
        }

        public void InQueue(int inf)            // положить в хвост очереди
        {
            Node p = new Node(inf, null);
            if (QueueIsEmpty())
            {
                Head = p; Tail = p;
            }
            else
            {
                Tail.Next = p; Tail = p;
            }
            Count++;
        }

        public int OutQueue()                   // взять из головы очереди
        {
            Node p = Head;
            Head = Head.Next;
            Count--;
            return p.Inf;
        }

        public static MyQueue RandomQueue(MyQueue q) // задать рандомную очередь из 20 элементов
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                int a=rnd.Next(-40,40);
                q.InQueue(a);
            }
            return q;
        }
        public string[] GetstringQueue(MyQueue q) // возвращяет string[] со значениями очереди
        {
            List<string> Lines = new List<string>();
            return (setlines(q.Head, Lines));
        }

        string[] setlines(Node a, List<string> Lines)
        {
            if (a != null)
            {
                if (a != Tail)
                {
                    Lines.Add(Convert.ToString(a.Inf));
                    setlines(a.Next, Lines);
                }
                else
                {
                    Lines.Add(Convert.ToString(a.Inf));
                }
            }
            return Lines.ToArray(); ;
        }
        public void ClearQueue(MyQueue Q)
        {
            Q.Tail = null;
            Q.Head=null;
        }
    }
}
