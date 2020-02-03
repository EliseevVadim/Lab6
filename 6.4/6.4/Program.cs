using System;
using System.IO;
namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"d:\файлы\6.4\Lab6_Temp");
            FileInfo file = new FileInfo(@"d:\файлы\6.1\lab.dat");
            if (!File.Exists(@"d:\файлы\6.4\Lab6_Temp\lab.dat"))
            {
                file.CopyTo(@"d:\файлы\6.4\Lab6_Temp\lab.dat");
            }
            FileStream startfile = new FileStream(@"d:\файлы\6.4\Lab6_Temp\lab.dat", FileMode.Open);
            BinaryReader reader = new BinaryReader(startfile);
            FileStream fileStream = new FileStream(@"d:\файлы\6.4\Lab6_Temp\lab_backup.dat", FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fileStream);
            for (int i=0; i<startfile.Length; i++)
            {
                byte a = reader.ReadByte();
                writer.Write(a);
            }
            writer.Close();
            FileInfo info = new FileInfo(@"d:\файлы\6.4\Lab6_Temp\lab.dat");
            Console.WriteLine($"Size: {info.Length} bytes");
            Console.WriteLine($"Last modified time: {info.LastWriteTime}");
            Console.WriteLine($"Last acess time is: {info.LastAccessTime}");
        }
    }
}
