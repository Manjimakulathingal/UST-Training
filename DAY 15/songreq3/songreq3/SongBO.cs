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
            List<Song> ls = new List<Song>();
            foreach (var item in songs)
            {
                if (item.SongType == type)
                {
                    ls.Add(item);
                }
            }
            return ls;
        }
        public List<Song> FindSong(List<Song> songList, DateTime dateCreated)
        {
            List<Song> ls = new List<Song>();
            foreach (var item in songList)
            {
                if (item.DateDownloaded == dateCreated)
                {
                    ls.Add(item);
                }
            }
            return ls;
        }
        public List<Song> FindSong(List<Song> SongList, double rating)
        {
            List<Song> ls = new List<Song>();
            foreach (var item in SongList)
            {
                if (item.Rating == rating)
                {
                    ls.Add(item);
                }
            }
            return ls;
        }
    }
}


