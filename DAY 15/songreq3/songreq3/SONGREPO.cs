using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songreq3
{
    internal class songrepo
    {
        static List<Song> songs = new List<Song>
        {

         new Song("my war","ssss","melody",8,10, DateTime.Parse("12-10-2022")),
         new Song("pandora","ssss","pop",8,10, DateTime.Parse("21-10-2022")),
         new Song("hakujitsu","ssss","melody",8,10, DateTime.Parse("12-10-2022"))

    };

        public static List<Song> Getsong()

        {

            return songs;

        }
    }
}

