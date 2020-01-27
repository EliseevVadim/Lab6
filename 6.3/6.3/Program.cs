using System;
using System.IO;
namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            StreamReader readtext = File.OpenText(@"d:\файлы\6.3\corrupted.txt");
            string s = readtext.ReadToEnd();
            char [] array = s.ToCharArray();
            for (int i=0; i<array.Length; i++)
            {
                if (Char.IsUpper(array[i]))
                {
                    array[i]=char.ToLower(array[i]);
                    counter++;
                }
            }
            s = new string(array);
            readtext.Close();
            StreamWriter fixedText = File.CreateText(@"d:\файлы\6.3\correct.txt");
            fixedText.WriteLine(s);
            fixedText.Close();
            Console.WriteLine($"Number of changes: {counter}");
        }
    }
}
