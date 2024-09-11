using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b;
                while (true)
                {
                    Console.Write("Nhap chieu cao : ");
                    if (double.TryParse(Console.ReadLine(), out a) && a > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }

                while (true)
                {
                    Console.Write("Nhap canh huyen: ");
                    if (double.TryParse(Console.ReadLine(), out b) && b > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }
                double tichso = Class1.DienTich(a,b);
                Console.WriteLine("Dien tich tam giac vuong la :" + tichso);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
