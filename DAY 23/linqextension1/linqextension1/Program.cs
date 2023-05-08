using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQDemo
    {
        class Program
        {
            static void Main(string[] args)
            {
                string s = "Welcome to Dotnet Tutorials";

                int wordCount = s.GetWordCount();
                

                Console.WriteLine($"Count : {wordCount}");
                Console.ReadKey();
            }
        }

        public static class ExtensionHelper
        {
            public static int GetWordCount(this string str)
            {
                if (!String.IsNullOrEmpty(str))
                    return str.Split(' ').Length;
                return 0;
            }
        }
    }
