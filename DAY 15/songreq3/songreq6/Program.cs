using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songreq6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<song> ls = new List<song>();
            Console.WriteLine("Enter the number of songs");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                double d = double.Parse(s[4]);
                int nd = int.Parse(s[5]);
                DateTime dt = new DateTime();
                dt = DateTime.ParseExact(s[3], "dd-MM-yyyy", null);
                song s1 = new song(s[0], s[1], s[2], dt, d, nd);
                ls.Add(s1);
            }
            Dictionary<string, int> sd = new Dictionary<string, int>();
            sd = song.CalculateTypeCount(ls);
            string a = song.PredictState(sd);
            Console.WriteLine("The user is feeling " + a);
        }
    }
    }

