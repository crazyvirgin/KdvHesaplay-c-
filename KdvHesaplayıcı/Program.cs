using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdvHesaplayıcı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("KDV HESAPLAYICI = ");
                Console.Write("Aldığınız Ürünün KDV Yüzdesini Giriniz =");
                int Kdv = Convert.ToInt32(Console.ReadLine());
                Console.Write("Aldığınız Ürünün Kdv Siz Fiyatının Giriniz =");
                int Fiyat = Convert.ToInt32(Console.ReadLine());
                int Kdvsi = (Fiyat * Kdv) / 100;
                int Kdvli = Fiyat + Kdvsi;

                Console.WriteLine("Aldığınız Ürünün Kdv'siz fiyatı {0}TL Uygulanan Kdv %{1} ",Fiyat,Kdv);
                Console.WriteLine("Aldığınız Ürünün Kdv'li fiyatı {0}TL Toplam Kdv {1}TL ", Kdvli, Kdvsi);
                Console.WriteLine("");
            }
        }
    }
}
