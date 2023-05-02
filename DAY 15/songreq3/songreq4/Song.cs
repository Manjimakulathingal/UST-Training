using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songreq4
{
    internal class Song 
    {

        private string _name;


        public string name
        {
            get { return _name; }
            set { _name = value; }
        }




        private string _artist;

        public string artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        private string _SongType;



        public string songtype
        {
            get { return _SongType; }
            set { _SongType = value; }
        }


        private double _rating;



        public double rating
        {
            get { return _rating; }
            set { _rating = value; }
        }


        private int _numberofdownloads;



        public int numofdownloads
        {
            get { return _numberofdownloads; }
            set { _numberofdownloads = value; }
        }

        private DateTime _dateDownload;



        public DateTime datedownload
        {
            get { return _dateDownload; }
            set { _dateDownload = value; }
        }

        public Song() { }

        public Song(string _name, string _artist, string _songtype, DateTime _dateDownload, double _rating , int _numberofdownloads)
        {
            name = _name;
            artist = _artist;
            songtype = _songtype;
            rating = _rating;
            numofdownloads = _numberofdownloads;
            datedownload = _dateDownload;
        }




        public override string ToString()

        {

            return string.Format("\nName: {0}\nArtist: {1}\nSongType: {2}\nRating: {3}" +

            "\nNumberOfDownLoads: {4}\nDateDownLoaded: {5}", _name, _artist, _songtype,

            _rating.ToString("0.0"), _numberofdownloads, _dateDownload);

            public  int CompareTo(Song other)

            {

                return this.name.CompareTo(other.name);

            }

        }

    }

    }



