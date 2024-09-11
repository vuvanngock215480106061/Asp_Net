using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
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
                    Console.Write("Nhap canh day : ");
                    if (double.TryParse(Console.ReadLine(), out b) && b > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }
                double dientich =( a * b)/2;
                Console.WriteLine("Dien tich tam giac la :" + dientich);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
