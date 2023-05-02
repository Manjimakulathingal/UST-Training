using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace songreq3
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

        public Song(string _name, string _artist, string _songtype, string _songname, double _rating, int _numberofdownloads, DateTime _dateDownload)
        {
            name = _name;
            artist = _artist;
            songtype = _songtype;
            rating = _rating;
            numofdownloads = _numberofdownloads;
            datedownload = _dateDownload;
        }

        public Song(string v1, string v2, string v3, int v4, int v5, DateTime dateTime)
        {
        }

        public override string ToString()
        {

            return String.Format($"name{_name}" + $"Artist{_artist}");

        }

    }

}

        
       





