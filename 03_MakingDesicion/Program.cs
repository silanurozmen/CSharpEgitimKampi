using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IfElse

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password=Console.ReadLine(); //konsol üzerinde okunan yazı password değişkenine atansın demek
            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı veri girişi");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result="hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);
            //Console.WriteLine();

            //if (average>0 &average < 30)
            //{
            //    result = "Çok kötü";
            //}
            //if (average > 30 & average < 50)
            //{
            //    result = "Kötü";
            //}
            //if (average > 50 & average < 75)
            //{
            //    result = "İyi";
            //}
            //if(average >75)
            //{
            //    result = "Çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcur");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}
            //Console.WriteLine("Lütfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();
            //if(username!="admin")
            //{
            //    Console.Write("bu kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş  geldiniz");
            //}


            #endregion

            #region Mod işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("Birinci sayının ikinci sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number%2==0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}
            #endregion


            #region Char Değişkenler ile karar yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team =='g' | team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if(team =='f' | team=='F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if(team=='b' | team=='B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion


            #region Örnek proje uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menüyü seçin: ");
            //menuItem = Console.ReadLine();

            //if(menuItem =="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-kızartma tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Kebabı");
            //    Console.WriteLine("------------Ana Yemekler------------");

            //}
            //if(menuItem=="2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("------------Çorbalar------------");
            //}
            //if(menuItem=="3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita Pizza");
            //    Console.WriteLine("2-Karışık Pizza");
            //    Console.WriteLine("3-Sucuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");
            //}
            //if(menuItem=="4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Kola");
            //    Console.WriteLine("------------İçecekler------------");
            //}
            //if (menuItem=="5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Supangle");
            //    Console.WriteLine("2-Tiramisu");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------Tatlılar------------");
            //}


            #endregion


            #region Switch Case

            //Console.Write("Lütfen Ay girişi Yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.WriteLine("Ocak");break;
            //    case 2:Console.WriteLine("Şubat");break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi yapıldı");break;
            //}


            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Birinci sayıyı giriniz: ");
            //number1=int.Parse (Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //number2=int.Parse (Console.ReadLine());

            //Console.Write("Lütfen yapmakk istediğiniz islemi giriniz: ");
            //symbol=char.Parse (Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;


            //}

            #endregion
















            Console.Read();
        }
    }
}
