using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon
{
    public class Otopark
    {
        public Araba[] Araba;
        public int front = -1;
        public int rear = -1;
        public int size = 0;
        public int count = 0;

        public Otopark(int size)
        {
            this.size = size;
            Araba = new Araba[size];
        }

        public void Ekle(Araba a)
        {
            if (count == size)
                throw new Exception(" OTOPARK DOLU! ");

            if (front == -1)
                front = 0;
            

            if (rear == size - 1 && count < 15)
                rear = 0;

            rear++;    
            Araba[rear] = a;
            count++;
        }

        public void Cikar()
        {
            if (IsEmpty())
                throw new Exception(" OTOPARK BOŞ!");
            Araba[front]= null;
            front++;
            count--;     
        }

        public void Sirala()
        {
            int tarama;
            bool swapped = false;
           
            for (tarama = front; tarama < count+front; tarama++)
            {            
                swapped = false;
                for (int i = front; i < (count + front - 1); i++)
                {  
                    if (Araba[i].CikisSuresi > Araba[i + 1].CikisSuresi)
                    {
                        int temp;
                        temp = Araba[i].CikisSuresi;
                        Araba[i].CikisSuresi = Araba[i + 1].CikisSuresi;
                        Araba[i + 1].CikisSuresi = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

        public void OncelikliCikar()
        {
            Sirala();
            Cikar();
        }

        public string Listele()
        {
            string temp="";
            // front =14 iken program patlar. Fixle.
            for (int i = front; i < count+front; i++)
			{
                temp += "Plaka:" + Araba[i].Plaka + "Cikis Suresi:" + Araba[i].CikisSuresi + Environment.NewLine;
			}
            return temp;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
        
        public int SureHesapla()
        {
            Random Sure = new Random();
            int sayi = Sure.Next(10, 300);
            return sayi;
        }

        public int TamamlanmaSuresiHesapla(int a)
        {
            int sure, toplamCikis = 0;
            for (int i = 0; i < a; i++)
            {
                if (Araba[i] == null)
                    continue;
                toplamCikis += Araba[i].CikisSuresi;
            }
            sure = toplamCikis / a;
            return sure;
        }
    }
}
