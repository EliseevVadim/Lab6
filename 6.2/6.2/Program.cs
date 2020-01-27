using System;
using System.IO;

namespace _6._2
{
    class Program
    {      
        static void Main(string[] args)
        {
            FileStream input = new FileStream(@"d:\файлы\6.2\input.dat", FileMode.Create);
            BinaryWriter ToInput = new BinaryWriter(input);
            for (int i=1; i<=128; i++)
            {
                ToInput.Write(i);
                ToInput.Write(Math.Log(i, 2));
            }
            ToInput.Close();
            FileStream read = new FileStream(@"d:\файлы\6.2\input.dat", FileMode.Open);
            BinaryReader reader = new BinaryReader(read);
            double[] array = new double[128];
            for (int i=0; i<array.Length; i++)
            {
                read.Seek(4, SeekOrigin.Current);
                array[i] = reader.ReadDouble();
            }
            reader.Close();
            FileStream output = new FileStream(@"d:\файлы\6.2\output.dat", FileMode.Create);
            BinaryWriter ToOutput = new BinaryWriter(output);
            for (int i=0; i<array.Length; i++)
            {
                ToOutput.Write(array[i]);
            }
            ToOutput.Close();
            Console.WriteLine("Files created!");
        }
    }
}
