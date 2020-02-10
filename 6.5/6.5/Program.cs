using System;
using System.IO;
namespace _6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();            
            byte[] arr = File.ReadAllBytes(@"d:\файлы\6.5\рисунки\" + s);
            string b = BitConverter.ToString(arr);
            string[] mas = b.Split("-");
            GetSize(mas);
            GetWidth(mas);
            GetHigh(mas);
            GetHorizontalResolution(mas);
            GetVerticalResolution(mas);
            GetBitPixel(mas);
            GetTypeOfCompression(mas);
        }
        static void GetSize(string [] arr)
        {
            string [] fix = new string[4];
            for (int i=0; i<fix.Length; i++)
            {
                fix[i] = arr[i+2];
            }
            for (int i=0; i<fix.Length/2; i++)
            {
                string temp = fix[i];
                fix[i] = fix[fix.Length - i - 1];
                fix[fix.Length - 1 - i] = temp;
            }
            string end = string.Join("",fix);
            int size = Convert.ToInt32(end, 16);
            Console.WriteLine($"Размер файла: {size}");
        }
        static void GetWidth(string [] array)
        {
            string[] fix = new string[4];
            for (int i = 0; i < fix.Length; i++)
            {
                fix[i] = array[i + 18];
            }
            for (int i = 0; i < fix.Length / 2; i++)
            {
                string temp = fix[i];
                fix[i] = fix[fix.Length - i - 1];
                fix[fix.Length - 1 - i] = temp;
            }
            string end = string.Join("", fix);
            int width = Convert.ToInt32(end, 16);
            Console.WriteLine($"Ширина: {width}");
        }
        static void GetHigh (string [] arr)
        {
            string[] fix = new string[4];
            for (int i = 0; i < fix.Length; i++)
            {
                fix[i] = arr[i + 22];
            }
            for (int i = 0; i < fix.Length / 2; i++)
            {
                string temp = fix[i];
                fix[i] = fix[fix.Length - i - 1];
                fix[fix.Length - 1 - i] = temp;
            }
            string end = string.Join("", fix);
            int high = Convert.ToInt32(end, 16);
            Console.WriteLine($"Высота: {high}");
        }
        static void GetHorizontalResolution (string [] arr)
        {
            string[] fix = new string[4];
            for (int i = 0; i < fix.Length; i++)
            {
                fix[i] = arr[i + 38];
            }
            for (int i = 0; i < fix.Length / 2; i++)
            {
                string temp = fix[i];
                fix[i] = fix[fix.Length - i - 1];
                fix[fix.Length - 1 - i] = temp;
            }
            string end = string.Join("", fix);
            int HorizontalResolution = Convert.ToInt32(end, 16);
            Console.WriteLine($"Горизонтальное разрешение: {HorizontalResolution}");
        }
        static void GetVerticalResolution(string [] arr)
        {
            string[] fix = new string[4];
            for (int i = 0; i < fix.Length; i++)
            {
                fix[i] = arr[i + 42];
            }
            for (int i = 0; i < fix.Length / 2; i++)
            {
                string temp = fix[i];
                fix[i] = fix[fix.Length - i - 1];
                fix[fix.Length - 1 - i] = temp;
            }
            string end = string.Join("", fix);
            int VerticalResolution = Convert.ToInt32(end, 16);
            Console.WriteLine($"Вертикальное разрешение: {VerticalResolution}");
        }
        static void GetBitPixel(string [] arr)
        {
            string[] fix = new string[2];
            for (int i = 0; i < fix.Length; i++)
            {
                fix[i] = arr[i + 28];
            }
            for (int i = 0; i < fix.Length / 2; i++)
            {
                string temp = fix[i];
                fix[i] = fix[fix.Length - i - 1];
                fix[fix.Length - 1 - i] = temp;
            }
            string end = string.Join("", fix);
            int BitPixel = Convert.ToInt32(end, 16);
            switch (BitPixel)
            {
                case 1:
                    Console.WriteLine("Кол-во бит/пиксель: 1 (monochrome palette)");
                    break;
                case 4:
                    Console.WriteLine("Кол-во бит/пиксель: 4 (4bit palletized)");
                    break;
                case 8:
                    Console.WriteLine("Кол-во бит/пиксель: 8 (8bit palletized)");
                    break;
                case 16:
                    Console.WriteLine("Кол-во бит/пиксель: 16 (16bit RGB)");
                    break;
                case 24:
                    Console.WriteLine("Кол-во бит/пиксель: 24 (24bit RGB)");
                    break;
            }            
        }
        static void GetTypeOfCompression(string[] arr)
        {
            string[] fix = new string[4];
            for (int i = 0; i < fix.Length; i++)
            {
                fix[i] = arr[i + 30];
            }
            for (int i = 0; i < fix.Length / 2; i++)
            {
                string temp = fix[i];
                fix[i] = fix[fix.Length - i - 1];
                fix[fix.Length - 1 - i] = temp;
            }
            string end = string.Join("", fix);
            int coefficient = Convert.ToInt32(end, 16);
            switch (coefficient)
            {
                case 0:
                    Console.WriteLine("Тип сжатия: без сжатия");
                    break;
                case 1:
                    Console.WriteLine("Тип сжатия: 8 bit RLE сжатие");
                    break;
                case 2:
                    Console.WriteLine("Тип сжатия: 4 bit RLE сжатие");
                    break;
            }
        }
    }
}
