using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mail2
{
    internal class mail
    {
        private long _id;
        public long Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }

        }
        private string _from;
        public string From


        {
            get { return From; }
            set { From = value; }
        }

        private string _to;
        public string To


        {
            get { return To; }
            set { To = value; }
        }
        private string _subject;
        public string Subject


        {
            get { return Subject; }
            set { Subject = value; }
        }
        private string _content;
        public string Content


        {
            get { return Content; }
            set { Content = value; }
        }
        private DateTime _receivedDate;
        public DateTime receivedDate


        {
            get { return receivedDate; }
            set { receivedDate = value; }
        }
        private double _size;
        private object _recieved;

        public double size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        


        public mail() { }




        public mail(long _id, string _to, string _from, string _subject, string _content, DateTime _received, double _size)
        {
            this.Id = _id;
            this.To = _to;
            this.From = _from;
            this.Subject = _subject;
            this.Content = _content;
            this.receivedDate = _received;
            this.size = _size;
        }
        public override string ToString()
        {
            return string.Format("id:{0}\n To:{1}\n From:{2}\n Subject:{3}\n Content:{4}\n receivedDate:{5}\n size:{6}\n", _id, _to, _from, _subject, _content, _received.ToString("dd-mm-yyyy", null), _size);
        }
        public static mail CreateMail(string details)
        {
            string[] s = details.Split(',');

            DateTime dt = DateTime.ParseExact(s[5], "dd-mm-yyyy", null);
            mail mailobj = new mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], dt, double.Parse(s[6]));
            return mailobj;



        }
    }
}
            


     

























