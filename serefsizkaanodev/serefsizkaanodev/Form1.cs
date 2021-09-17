using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serefsizkaanodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Değişken tipleri:

        /* 
          Değer tipleri => int, long, float, double, decimal, char, bool, byte, short, struct, enum.
          Ram'de stack bölgesinde tutulur.

          Referans Tipler, => string, object, class, interface, array, delegate,pointer.
          Ram'de heap bölgesinde tutulur.
         
         Bu veri tiplerini ayıran özellik ise bellekte tutma şeklidir.Stack Heap’den daha hızlıdır.        
*/

        //Const Nedir ?

        /*
         Bir değişkenin program boyunca değeri sabit ise const kullanılır.
         const DataType x=1; şeklinde tanımlanır.
         Değişken olarak tanımlanan bir değere sonradan sabit değer tanımlanamaz.



         */


        /*
          Metot:

       private: sadece kullanılan class içinde kullanılabilir.
       public: uygulamanın tamamında kullanılır.
       static: private ve public ifadesinden sonra static konulursa metot doğrudan kullanılır.Eklenmez ise
   içerisine değişken eklenerek kullanılır.
       paramemtreler: metota dışarıdan değer gönderilmeyecekse metot oluşturulurken parantez içi boş bırakılır.
   Fakat dışarıdan değer gönderilicekse parantez içine gönderilecek değer için değişken oluşturulması gerekir. 
   örn (int x , int y ) veya (string a , string b)
         void: eğer metot geri değer döndürüyorsa void yazılması gerekmez fakat geri değer döndürüyorsa değerin
       değişkeni buraya yazılmalıdır.
         */

        //Acces modifiers : Programın güvenliğini arttırma amacıyla kullanılır.
        /*
         Private: Sadece kendi classı içerisinde ulaşabilmesini sağlar.Genelde program içerisinde değiştirilmemesi gereken
      kodlar barındırır.Dışarıdan ulaşım olamaz.

         Public:Programda herhangi bir yerden ulaşılması sağlanır.Herhangi bir kısıt yoktur.

         Protected:Kod içinde bir değerin protected olarak tanımlanması; o değere, bulunduğu class  ve ondan türetilen diğer
     sınıflar içinden erişilebilir olduğunu göstermektedir. 
        public ve private erişim belirleyicilerinin birleşimi olarak görülebilmektedir.

         İnternal: Aynı programda erişilebilir fakat farklı programda erişilemez.

         Protected İnternal: Tanımlanan class ve ondan türetilen classlarda erişilebilir.Aynı programda olması önemli değildir.   

         */

        /*Metot Params: parametre sayısı belirli olmadığı yerlerde kullanılır.Örneğin 2 sayı toplamında girilen
    değerlerin 2 adet olacağı bellidir.Fakat her durumda bu belli olmaz. */

        //int top(params int[] sayilar);



        /* 
         foreach: dizi temelli döngülerde foreach kullanılır
         while: döngü şart sağlandığı sürece çalışır.
         do-while: Şart sondadır. Program bir kere veya şarta göre çalışır. Giriş işlemleride genelde kullanılır.
        for: Birbirini tekrar eden işlemi daha düzenli hale getirmemizi sağlar. Örneğin 0'dan 100 e kadar olan sayıları yazmak
        için alt alta yazacağımıza 3 satırlık döngü ile bunu yazdırabiliriz.
          if-else : koşul durumlarında kullanılır. eğer sayı=0 ise ... değil ise ... şeklinde kullanılır.


         */





        //List - Generic List

        /*
         10 adet sayıyı ayrı ayrı tanımlamaktansa bunları listede tanımlamak bize hem yer hemde zaman kazandırır.
        Fakat gireceğimiz sayı sayısı belirli değilse bu sefer generic list kullanmalıyız.
        list<> içerisinde bir sınıfda tutabiliriz.


         */
        public static void deneme()
        {
            MessageBox.Show("Test");
        }

        class ornek
        {
            public static void test()
            {
                MessageBox.Show("Hayırlı Cumalar");
            }

        }
        public static void cagır(string metin)
        {
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show(metin);
            }
        }

        private static int toplam(int x, int y)
        {
            /*değer göndereceği için return yazıyorum.*/
            return (x + y);

        }

        class alanhesap
        {
            public static double alanhesaplama(double kisa, double uzun)
            {
                double alan = kisa * uzun;
                return (alan);
            }
            public static double cevrehesapla(double kisak, double uzunk)
            {
                double cevre = 2 * (kisak * uzunk);
                return (cevre);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  deneme();
            // ornek.test();
            /*  string yazi = "selamın aleyküm";
              cagır(yazi); */

            //----------------------------------------------------------------------------------------------
            /*   if (textBox1.Text=="")
               {
                   MessageBox.Show("Textbox1 içerisi boş.");
               }
               else if (textBox2.Text=="")
               {
                   MessageBox.Show("Textbox2 içerisi boş.");
               }
               else
               {
                   int top1 = Convert.ToInt32(textBox1.Text);
               int top2 = Convert.ToInt32(textBox2.Text);
                   int sonuc = toplam(top1, top2);
                  MessageBox.Show(sonuc.ToString());
               }*/
            // -----------------------------------------------------------------------------------
            /*
                        double k = Convert.ToInt32(textBox1.Text);
                        double u = Convert.ToInt32(textBox2.Text);
                        double sonuc = alanhesap.alanhesaplama(k, u);
                        double sonuc2 = alanhesap.cevrehesapla(k, u);
                        MessageBox.Show("alan"+sonuc.ToString());
                        MessageBox.Show("çevre"+sonuc2.ToString()); */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*    string[] ogrenci = new string[3] { "Enis", "Fahri Yurddan", "Kaan Ogecan" };
                foreach (var ogr in ogrenci)
                {
                    MessageBox.Show(ogr.ToString());
                }
                */

            //-----------------------------------------------------------------------------------
            /*
            string ad = textBox1.Text;
            int sifre = Convert.ToInt32(textBox2.Text);
            int deneme = 3;
            if (ad == "kaan" && sifre == 1234)
            {
                MessageBox.Show("Hoşgeldin");
            }
            else
            {
                do
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                    deneme--;
                } while (deneme!=0);
                { MessageBox.Show("Başarısız giriş. Program Kapatılıyor.");}
            }
           
    */
        }

        class sinif
        {
            public string ograd;
            public string ogrsoy;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            var sayi = new List<int>() {10,11,12,13 };
            sayi.Add(31);
            sayi.Add(32);

            for (int i = 0; i < sayi.Count; i++)
            {
                MessageBox.Show(sayi[i].ToString());
            }
            foreach (var sayilarim in sayi)
            {
                MessageBox.Show(sayi[3].ToString());
            }
            var metin = new List<string>() {"a","b","c" };
            metin.Add("otuzbir");
            metin.Add("otuziki");

            var ogrenci = new List<sinif>();
            ogrenci.Add(new sinif { ograd = "Kaan", ogrsoy = "Ogecan" });
            ogrenci.Add(new sinif { ograd = "Fahri", ogrsoy = "Yurddan" });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int araci;
            int[] sayilar = new int[7] { 10, 20, 25, 35, 52, 66, 58 };
          
            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int j = i; j<sayilar.Length; j++)
                {
                    if (sayilar[i]>sayilar[j])
                    {
                        araci = sayilar[j];
                        sayilar[j] = sayilar[i];
                        sayilar[i] = araci;
                    }
                }
            }

            foreach (var item in sayilar)
            {
                listBox1.Items.Add(item);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            int[] sayilar = new int[5] { 31, 45, 7, 5, 8 };
            Array.Sort(sayilar);
            Array.Reverse(sayilar);
            foreach (var item in sayilar)
            {
                listBox1.Items.Add(item);
            }
           
        }
    }
}
