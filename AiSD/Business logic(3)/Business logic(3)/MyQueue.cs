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

        public MyQueue DeleteNegative(MyQueue Q,Node a)
        {
            if ((a != null)&&(a.Next!=null))
            {
                if (a == Q.Head)                             //работа с головой
                {
                    if (a.Inf < 0)
                    {
                        Q.Head = find(Q, a.Next);
                        DeleteNegative(Q, Q.Head.Next);
                    }
                }

                if ((a.Next == Q.Tail) && (a.Next.Inf < 0))  //работа с концом
                {
                    Q.Tail = a;
                    return Q;
                }

                if (a.Next.Inf < 0)                   //работа с серединой
                {
                    if (find(Q, a.Next) == null)
                    {
                        Q.Tail = a;
                        return Q;
                    }
                    a.Next = find(Q, a.Next);
                }
                if (a != Q.Tail)
                    DeleteNegative(Q, a.Next);
            }
                return Q;
        }
        Node find(MyQueue Q, Node a)
        {
            if (a != null)
            {
                if (a.Inf >= 0)
                    return a;
                else
                {
                    if (a != Q.Tail)
                        find(Q, a.Next);
                }
            }
            return a;
        }

        public  MyQueue Delete(MyQueue Q)
        {
            return DeleteNegative(Q,Q.Head); 
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
            if (a != Tail)
            {
                Lines.Add(Convert.ToString(a.Inf));
                setlines(a.Next,Lines);
            }
            else
            {
                Lines.Add(Convert.ToString(a.Inf));
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
