using System.Xml.Linq;

namespace Telstrore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            bool f = false;
            Stok mehsullar = new Stok();

            do
            {
                
                Console.WriteLine("1.AddProduct    2.ShowAll    3.Sale    4.Search    0.Exit");

                string Secim= Console.ReadLine();


                switch (Secim)
                {
                    case "1":
                        Console.WriteLine("Cihaz adi daxil edin:");
                        string Name = Console.ReadLine();
                        bool price_bool;
                        double Price;
                        do
                        {
                            Console.WriteLine("Qiymet daxil edin:");
                            
                            price_bool = double.TryParse(Console.ReadLine(), out Price);

                            if (Price > 0)
                            {
                                price_bool = true;
                            }
                            else
                            {
                                price_bool= false;
                            }
                        } while (!price_bool);

                        bool count_bool;
                        int Count;
                        do
                        {
                            Console.WriteLine("Say daxil edin:");                            
                            count_bool = int.TryParse(Console.ReadLine(), out Count);
                            if (Count > 0)
                            {
                                count_bool= true;
                            }
                            else
                            {
                                count_bool = false;
                            }
                        } while (!count_bool);

                        Equipment cihaz = new Equipment(Name, Price, Count);
                        mehsullar.AddProduct(cihaz);

                        break;
                    case "2":
                        mehsullar.Show();
                        break;

                    case "3":
                        Console.WriteLine("Mehsul secin:");
                        string name = Console.ReadLine();
                        mehsullar.Sale(name);
                        break;
                    case "4":
                        Console.WriteLine("Axtardiginiz Mehsul:");
                        string seach= Console.ReadLine();
                        mehsullar.Search(seach);
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }


            } while (!f);

        }
    }
}
