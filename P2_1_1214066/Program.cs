using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kalkulator simple");
            Console.Write("masukkan nilai pertama ");
            var angka1 = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai kedua ");
            var angka2 = int.Parse(Console.ReadLine());

            var penjumlahan = angka1 + angka2;
            var pengurangan = angka1 - angka2;
            var perkalian = angka1 * angka2;
            var pembagian = angka1 / angka2;

            Console.Write(angka1);
            Console.Write(" + ");
            Console.Write(angka2);
            Console.Write(" = ");
            Console.WriteLine(penjumlahan);

            Console.Write(angka1);
            Console.Write(" - ");
            Console.Write(angka2);
            Console.Write(" = ");
            Console.WriteLine(pengurangan);

            Console.Write(angka1);
            Console.Write(" * ");
            Console.Write(angka2);
            Console.Write(" = ");
            Console.WriteLine(perkalian);

            Console.Write(angka1);
            Console.Write(" / ");
            Console.Write(angka2);
            Console.Write(" = ");
            Console.WriteLine(pembagian);
        }
    }
}
