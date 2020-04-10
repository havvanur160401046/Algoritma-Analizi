using System;

namespace Analiz_Ödevi
{
    class Dizi
    {
            public int elemansayi { get; set; }
            public int kapasite { get; set; }
            public int[]dizi { get; set; }


        public void diziOlustur()
        {
            elemansayi = 0;
            kapasite = 1;
            dizi = make(kapasite);
 
        }
        public int[] make(int kapasite)
        {
            int[] dizi1 = new int[kapasite];
            return dizi1;

        }
 
        public int[] resize(int Kapasite, int[] dizi)//resize fonksiyonu yeni kapasiteli dizi oluşturuluyor
        {
            //resize() -> complexiy=> n olur O(n)
            // Array.Resize(ref dizi, Kapasite); fonksiyonuylada dizi kapasitesi arttırılabilir
            int[] Yeni = make(Kapasite);//Yeni kapasiteye ait dizi oluşturuldu
            Console.WriteLine(" şu an amortized cost işlemi ... ");
            Console.WriteLine("Yeni Kapasite=" + Kapasite);
            for (int i=0;i<dizi.Length;i++)
            {
                Yeni[i] = dizi[i];//elemanlar yeni diziye atanıyor
                Console.WriteLine(" şu an move işlemi ... ... ");
            }
            dizi = Yeni;
            kapasite = Kapasite;
            return dizi;
           
        }
            
        public void append(int eleman) // worst-case O(n) , best-case O(1)
        {
            if (elemansayi == kapasite)
            {
                //kapasite yetersiz
                dizi = resize(2 * kapasite, dizi);       
            }
          
             dizi[elemansayi] = eleman;
             elemansayi += 1;
            Console.WriteLine(eleman+ " elemanı eklendi:" );
            Console.WriteLine("Dizideki eleman sayısı:"+elemansayi);
            
           
        }
        public void remove()// complexiy => O(1) olur (if ya da else )
        {
            if(elemansayi == 0)
            {
                Console.WriteLine("Silinecek eleman yok");
               
            }
            else
            {
                Console.WriteLine("Dizideki eleman sayısı:" + elemansayi);
                Console.WriteLine(dizi[elemansayi - 1]+"  elemanı silindi");
                Array.Clear(dizi, elemansayi-1,1);
                elemansayi -= 1;
                Console.WriteLine("Dizideki eleman sayısı:" + elemansayi);

            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Dizi nesne = new Dizi();
            nesne.diziOlustur();
            nesne.remove();//dizi boşken silme işlemi yapılması durumu
            for (int i=1;i<6;i++)
            {
                Console.WriteLine("------------------------");
                nesne.append(i);
            }
            for(int j=0;j<4;j++)
            {
                Console.WriteLine("-------------------------");
                nesne.remove();
            }
            

        }
    }
}
