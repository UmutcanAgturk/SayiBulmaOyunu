using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tusasKazanOdev1SeviyeliSayiBulma03._01._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int sistutan, tahmin;
            Random rnd = new Random();//Random bir sayı oluşturarak o sayıyı tutuyorum      
            Console.WriteLine("Seviyenizi Belirleyiniz \n Kolay (1-10) 1 Tuşuna basınız \n Orta (1-25) 2 Tuşuna basınız \n Zor (1-50) 3 Tuşuna basınız");
            String secim = Console.ReadLine();//kullanıcının seçim yaptığı sayıyı çekip okuyorum


            if (secim == "1")
            {
                int hak = 6;
                sistutan = rnd.Next(1,10);
                while (true)
                {
                   
                        Console.WriteLine(hak--+ "Hakkınız Var.");//if içinde verdiğimiz hak sayısı kadar hak veriyoruz ve her bilinmelidiğinde hak sayısını azaltıyorum
                        if (hak<=0)
                        {
                            Console.WriteLine("Hakkınız Bitti");
                            break;
                        }
                        Console.WriteLine("\n\n\nBir Sayı Giriniz");
                        tahmin = Convert.ToByte(Console.ReadLine());//kullanıcının seçim yaptığı sayıyı çekip okuyorum
                    if (tahmin==sistutan)
                        {
                            Console.WriteLine("Tebrikler Bildiniz");
                            break;
                        }
                        else if (tahmin>sistutan)
                        {
                            Console.WriteLine("Daha Küçük Bir Sayı Giriniz");
                        }
                        else
                        {
                            Console.WriteLine("Daha Büyük Bir Sayı Giriniz");
                        }

                    
                }
                
            }


            else if (secim == "2")
            {
                int hak = 4;
                sistutan = rnd.Next(1, 25);
                while (true)
                {
                   
                       
                        if (hak <= 0)
                        {
                            Console.WriteLine("Hakkınız Bitti");
                            break;
                        } 
                    Console.WriteLine(hak-- + "Hakkınız Var.");
                    Console.WriteLine("\n\n\nBir Sayı Giriniz");
                    tahmin = Convert.ToByte(Console.ReadLine());
                        if (tahmin == sistutan)
                        {
                            Console.WriteLine("Tebrikler Bildiniz");
                            break;
                        }
                        else if (tahmin > sistutan)
                        {
                            Console.WriteLine("Daha Küçük Bir Sayı Giriniz");
                        }
                        else
                        {
                            Console.WriteLine("Daha Büyük Bir Sayı Giriniz");
                        }
                    
                }

            }



            else if (secim == "3")
            {
                int hak = 2;
                sistutan = rnd.Next(1, 50);
                while (true)
                {

                  if (hak <= 0)
                  {
                            Console.WriteLine("Hakkınız Bitti");
                            break;
                  }
                        Console.WriteLine(hak-- + "Hakkınız Var.");

                        Console.WriteLine("\n\n\nBir Sayı Giriniz");

                        tahmin = Convert.ToByte(Console.ReadLine());

                 if (tahmin == sistutan)
                 {
                            Console.WriteLine("Tebrikler Bildiniz");
                            break;
                 }
                else if (tahmin > sistutan)
                 {
                            Console.WriteLine("Daha Küçük Bir Sayı Giriniz");
                 }
                        else
                 {
                            Console.WriteLine("Daha Büyük Bir Sayı Giriniz");
                 }
                    
                   
                }
            }
            
        }
    }
}
