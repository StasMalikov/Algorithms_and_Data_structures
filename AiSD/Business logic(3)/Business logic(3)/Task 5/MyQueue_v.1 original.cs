using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;
using Business_logic_3_;

namespace Business_logic_3_
{
   public class MyQueue
    {
        public Node Head { get; set; }                          
        public Node Tail { get; set; }
        public int Count { get; set; }                   

        public MyQueue()
        {
            Head = null; 
            Tail = null; 
            Count = 0;
        }
        public void SortSame()
        {
            DellSameNUM(Head);
        }
        public void DellSameNUM(Node a)
        {
            while((a!=null)&&(a.Next!=null))
            {
                if(a.Inf!=a.Next.Inf)
                {
                    a = a.Next;
                    continue;
                }
                if (a.Next.Next!=null)
                {
                    if (Head == a)
                    {
                        Head = a.Next;
                        continue;
                    }
                    a.Next = findSame(a.Next.Next,a.Inf);
                    if(a.Next==null)
                    {
                        Tail = a;
                        break;
                    }
                    a = a.Next;
                }
                else {
                    Tail = a;
                     break;
                }
            }
            Tail = a;
        }
        Node findSame(Node a,int inf)
        {
            if (a != null)
            {
                if (a.Inf != inf)
                {
                    return a;
                }
                else
                {
                    return findSame(a.Next,inf);
                }
            }
            return null;
        }
        public void Delete()
        {
            Head = find(Head);
            Sortnegative(Head);
        }

        public void Sortnegative(Node a)
        {
            if(a!=null)
            if (find(a.Next) == null)
            Tail = a; 
            else { 
                a.Next = find(a.Next);
                Sortnegative(a.Next);
            }
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
                    return find(a.Next);
                }
            }
            return null;
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
        public void InitQueue(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                InQueue(arr[i]);
            }
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
