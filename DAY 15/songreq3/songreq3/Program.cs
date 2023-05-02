using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songreq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = songrepo.Getsong();
                

            foreach (Song song in list)

            {

                Console.WriteLine(song.ToString());

            }


        }
    }
}
