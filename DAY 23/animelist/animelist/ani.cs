using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animelist
{
    public class ani
    {
        

          private string name 
            ;
       

        public string Name
        {
            get; set;
        }



        private string genre;

        

        public string Genre
        {
            get { return Genre; }
            set { Genre = value; }
        }

        private int rate;

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public ani() { }
        public ani (string name , string genre , int rate)
        {
            this.Name = name;
            this.genre = genre;
            this.rate = rate;
        }


    }
}
