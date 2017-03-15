using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VERİODEV2
{   [Serializable()]
    public class LinkedList : LinkedListADT
    {
        public override void InsertFirst(object value)
        {
            Node tmpHead = new Node 
            { 
                Data = value 
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }
            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }

        public override void InsertLast(object value)
        {
            Node Last = new Node
            {
                Data = value
            };

            if(Head== null)
            {
                Head = Last;

            }
            else
            {
                Node Search = Head;
               
                while(Search.Next!=null)
                {
                    Search = Search.Next;

                }
                Search.Next = Last;


            }
            Size++;


           

           
        }

        public override void InsertPos(int position, object value)
        {
            Node eklenecekeleman = new Node
        
            {
                Data = value
            };
            if (Head == null)
            {
                Head = eklenecekeleman;

            }



            else
            {
                
                Node temp = Head;
                if(position>Size)
                    System.Windows.Forms.MessageBox.Show("Dizi Size'indan buyuk deger girdiniz");
                else if (position == 1)
                    InsertFirst(value);
                else { 
               
                for(int i=1; i< position-1; i++)
                {   
                    
                    temp = temp.Next;

                }
                eklenecekeleman.Next = temp.Next;
                temp.Next = eklenecekeleman;

                }
                Size++;

            }

           


        }

        public override void DeleteFirst()
        {
            if (Head != null)
            {
                //Head'in next'i HeadNext'e atanıyor
                Node HeadNext = this.Head.Next;
                //HeadNext null ise zaten tek kayıt olan Head silinir.
                if (HeadNext == null)
                    Head = null;
                else
                    //HeadNext null değilse yeni Head, HeadNext olur.
                    Head = HeadNext;
                //Listedeki eleman sayısı bir azaltılıyor
                Size--;
            }
        }

        public override void DeleteLast()
        {
            Node toDel = new Node();
            if (Head.Next == null)
                Head = null;

            else { 
            Node travers = Head;

            while(travers.Next!=null)

            {
                toDel = travers;
                travers = travers.Next;

            }
            toDel.Next = null;

            }
        }


        public override void DeletePos(int position)
        {
            Node previous = new Node();

            if (position == 1)
                DeleteFirst();

            else if (Head == null)
            {
                Head = previous;

            }



            else
            {
                
                Node temp = Head;
                if (position > Size)
                    System.Windows.Forms.MessageBox.Show("Dizi Size'indan buyuk deger girdiniz");

                else {

                    for (int i = 0; i < position - 1; i++)
                    {
                        previous = temp;
                        temp = temp.Next;

                    }
                    previous.Next = temp.Next;
                   
                    


                }
                Size--;
            }
        }

        public override Node GetElement(int position)
        {

            Node temp = new Node();
            Node travers = Head;


            if (position == 1)
                temp = Head;


            else
            {


                if (position > Size)
                    System.Windows.Forms.MessageBox.Show("Dizi Size'indan buyuk deger girdiniz");

                else {

                    for (int i = 0; i < position - 1; i++)
                    {
                        travers = travers.Next;



                    }



                    temp = travers;

                }

            }

            return temp;




            
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }

            return temp;
        }

        


    }
}
