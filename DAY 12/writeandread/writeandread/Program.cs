using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writeandread
{
    internal class Program
       
    {
        static string file = @"D:\UST Traning\DAY 13\poem.txt";
        static void Main(string[] args)
        {
            Write();
           // Read();
        }
        static void Write()
        {
            StreamWriter filestream = new StreamWriter(file);
            filestream.WriteLine("blahhh blahhh");
            filestream.WriteLine("blaaaahhh");
            filestream.Close();
        }
    }

}
