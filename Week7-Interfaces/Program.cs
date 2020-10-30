using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseFile> files = new List<BaseFile>();

            files.Add(new CompressedTextFile("Test.txt", "Compress this data!"));
            files.Add(new WordFile("Test.doc"));
            files.Add(new CompressedTextFile("Test1.txt", "Compress this data!"));
            files.Add(new WordFile("Test1.doc"));
            files.Add(new CompressedTextFile("Test2.txt", "Compress this data!"));
            files.Add(new WordFile("Test2.doc"));

            foreach (BaseFile f in files)
            {
                Console.WriteLine(f.Name);
                if (f is ICompressible fIC)
                    fIC.Compress();
                if (f is IStorable fIS)
                    fIS.Store(f.Name);
                if (f is IPrintable fIP)
                    fIP.Print();
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
