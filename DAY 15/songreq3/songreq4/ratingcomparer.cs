using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songreq4
{
    internal class ratingcomparer
    {
        public class RatingComparer : IComparer<Song>

        {

            int IComparer<Song>.Compare(Song x, Song y)

            {

                return y.Rating.CompareTo(x.Rating);

            }

        }

    }

}
