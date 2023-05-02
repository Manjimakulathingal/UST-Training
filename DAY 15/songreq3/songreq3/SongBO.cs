using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songreq3
{
    internal class songBO
    {
        public List<Song> findSongs(List<Song> songs, string type)

        {

            foreach (Song song in songs)

            {

                if (song.songtype == type)

                {

                    return songs;

                }

                else

                {

                    return null;

                }

            }

            return null;

        }
    }
}
