using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Telstrore
{
    internal class Stok
    {
        public Equipment[] mehsullar;

        


        public Stok()
        {
            mehsullar = new Equipment[0];
            
        }

        public void AddProduct(Equipment equipment)
        {
            Array.Resize(ref mehsullar, mehsullar.Length + 1);
            mehsullar[mehsullar.Length - 1] = equipment;
        }



        public void Show()
        {
            for (int i = 0; i < mehsullar.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Mehsul:{mehsullar[i].ProductName} Qiymet:{mehsullar[i].Price} Say:{mehsullar[i].Count}");
                Console.WriteLine();
            }
        }

        public void Sale(string name)
        {

            for (int i = 0; i < mehsullar.Length; i++)
            {
                if (name == mehsullar[i].ProductName && mehsullar[i].Count > 0)
                {
                    Console.WriteLine("Axtardiginiz mehsul ve qiymeti:" + mehsullar[i].ProductName + "," + mehsullar[i].Price);
                    Console.WriteLine("Stokda " + mehsullar[i].Count + " Eded Qalib");
                    Console.WriteLine("Mehsulu almaq isteyirsiniz?(Beli/Xeyr)");
                    string user_secim = Console.ReadLine();

                    if (user_secim == "Beli")
                    {
                        Console.WriteLine("Mehsul elde etmek ucun musteri melumatlarini daxil edin");
                        Console.WriteLine("Ad ve Soyad:");
                        string user_name = Console.ReadLine();
                        Console.WriteLine("Balansinizi daxil edin:");
                        bool user_balans;
                        double userbalans;
                        do
                        {

                            user_balans = double.TryParse(Console.ReadLine(), out userbalans);
                        } while (!user_balans);
                        if (userbalans > mehsullar[i].Price)
                        {
                            Console.WriteLine("Mehsulu ugurla aldiniz!");
                            mehsullar[i].Count--;
                            
                        }
                        else
                        {
                            Console.WriteLine("Kifayet qeder mebleg yoxdur!");
                        }
                    }
                    else if (user_secim == "Xeyr")
                    {
                        Console.WriteLine("Gorusenedek)");
                    }

                }
                else if (mehsullar[i].Count == 0)
                {                    
                    Console.WriteLine("Stokda qalmiyib!");                
                }
                else
                {
                    Console.WriteLine("Beli bir mehsul yoxdu!");
                }
            }            
        }
        public void Search(string search)
        {
            for (int i = 0;i<mehsullar.Length;i++)
            {
                if (search == mehsullar[i].ProductName)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Mehsul:{mehsullar[i].ProductName} Qiymet:{mehsullar[i].Price} Say:{mehsullar[i].Count}");
                    Console.WriteLine();
                }
            }
        }
    }
}
