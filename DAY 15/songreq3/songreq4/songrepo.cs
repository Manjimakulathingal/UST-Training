using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songreq4
{
    internal class songrepo
    {
        static List<Song> songs = new List<Song>

    {

      new Song("Shape of You","Edsheeran","Pop",DateTime.Parse("12-01-2018"), 4 , 1009),

      new Song("Perfect", "Edsheeran","Pop",DateTime.Parse("06-08-2017"),4,8907),

      new Song("Mercy","Shawn Mendes","Jazz",DateTime.Parse("03-09-2016"), 6 , 8754)

    };

        public static List<Song> GetAllSongs()

        {

            return songs;

        }
    }
}
