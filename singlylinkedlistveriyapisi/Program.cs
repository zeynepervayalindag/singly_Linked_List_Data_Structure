using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlylinkedlistveriyapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class SinglyLinkedList
    {
        private Node First;
        public class Node
        {
            public int data;
            public Node Next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public void Sonaekleme(int data)
        {
            Node eleman = new Node(data);
            if (First == null)
            {
                First = eleman;
            }
            else
            {
                Node temp = First;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = eleman;
            }
        }
        public void Basaekleme(int data)
        {
            Node eleman = new Node( data);
            if(First==null)
            {
                eleman = First;
            }
            else
            {
                eleman.Next = First;
                First = eleman;
            }
        }
        public void Bastansilme()
        {
            if(First==null)
            {
                Console.WriteLine("Bağlı liste boştur.");
            }
            else
            {
                First = First.Next;
            }
        }
            public void SondanSilme()
        {
            if(First==null)
            {
                Console.WriteLine("Bağlı liste boştur.");
            }
            else if(First.Next==null)
            {
                First = null;
            }
            else
            {

                Node temp = First;
                Node temp2 = temp;
                while(temp.Next!=null)
                {
                    temp2 = temp;
                    temp = temp.Next;
                }
                temp2.Next = null;
            }
 }
        public void arayaekle(int indis,int data)
        {
            Node eleman =new Node(data);
            bool sonuc = false;
            if(First==null&&indis==0)
            {
                First = eleman;
                sonuc = true;
            }
            else if (indis == 0)
            {
                Basaekleme(data);
                sonuc = true;
            }
            else
            {
                Node temp = First;
                Node temp2 = temp;
                int i = 0;
                while (temp.Next != null)
                {
                    if (i == indis)
                    {
                        sonuc = true;
                        temp2.Next = eleman;
                        eleman.Next = temp;
                        break;
                    }
i++;
                    temp2 = temp;
                    temp = temp.Next;
                }
                }
        }
        public void aradansilme(int indis)
        {
            bool sonuc = false;
            if(First==null)
            {
                sonuc = true;
                Console.WriteLine("Bağlı liste boş");
            }
            else if(First.Next==null&&indis==0)
            {
                sonuc = true;
                First = null;
            }
            else if(First.Next!=null&&indis==0)
            {
                Bastansilme();
            }
            else
            {
                int i = 0;
                Node temp=First;
                Node temp2 = temp;
                while(temp.Next!=null)
                {
                    if(i==indis)
                    {
                        sonuc = true;
                        temp2.Next = temp.Next;
                        i++;
                        break;
                    }
                }
                if (i == indis)
                {
                    temp2.Next = null;
                    i++;
                }
                if(sonuc==false)
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız");
                }
            }
        }
 }
}
