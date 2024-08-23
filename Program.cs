using System;

namespace DemSoLanXuatHienKiTu
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] s = {"a", "h", "h", "b", "w", "c", "c"};
           Console.WriteLine("Nhap ki tu bat ki co trong mang : ");
           string x = Console.ReadLine();
           Console.WriteLine("So lan xuat hien cua ki tu {0} la : ", x);
           count(s, x);
        }

         static void count(string[] z, string n)
        {
           int dem = 0;
           for (int i = 0; i < z.Length; i++)
           {
               if (z[i] == n)
                  dem++;
           }
           Console.WriteLine(dem);
        }
    }
}