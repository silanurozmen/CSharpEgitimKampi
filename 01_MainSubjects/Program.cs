using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Merhaba");


            //Console.WriteLine("**** Yemek Kategorileri ****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("**** Yemek Kategorileri ****");


            #endregion

            #region StringDeğişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Sıla";
            //Console.Write(name);

            //string custumerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //custumerName = "Arda";
            //customerSurname = "Özmen";
            //customerPhone = "3058358";
            //customerEmail = "arda@gmail..com";
            //district = "Keçiören";
            //city = "Ankara";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Müşteri: " + custumerName + " " + customerSurname);
            //Console.WriteLine("İletişim: "+customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşe";
            //customerSurname = "Kaya";
            //customerPhone = "+90 562 666 6666";
            //customerEmail = "test@gmail.com";
            //district = "Keçiören";
            //city = "Ankara";

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Müşteri: " + custumerName + " " + customerSurname);
            //Console.WriteLine("İletişim: "+customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------");


            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---- Kola: " + cokePrice + "TL");
            Console.WriteLine("---- Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("---- Su:" + waterPrice + "TL");
            Console.WriteLine("---- Patates Kızartması: " + friesPrice + "TL");
            Console.WriteLine("---- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("---- Limonata: " + lemonadePrice + "TL"  );
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalWaterPrice;
            int totalCokePrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 1;
            waterCount = 1;
            friesCount = 0;
            pizzaCount = 1;
            lemonadeCount = 2;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice= lemonadePrice * lemonadePrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;

            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: "+ totalHamburgerPrice+ "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Fries Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalFriesPrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice + totalCokePrice;
            Console.WriteLine("Toplam ödenecek tutar: " + totalPrice + "TL");

            #endregion
            Console.Read();

        }
    }

}
