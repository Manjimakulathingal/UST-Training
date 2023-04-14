using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mailfolder
{
    internal class mailfolder
    {



        private long _Id;
        private string _To;
        private string _From;
        private string _Subject;
        private string _Content;
        private DateTime _receivedData;
        private double _size;



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




        public string To


        {
            get { return To; }
            set { To = value; }
        }

        public string From


        {
            get { return From; }
            set { From = value; }
        }
        public string Subject


        {
            get { return Subject; }
            set { Subject = value; }
        }
        public string Content


        {
            get { return Content; }
            set { Content = value; }
        }

        public DateTime receivedDate

    
        {
            get { return receivedDate; }
            set { receivedDate = value; }
        }

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

        public mailfolder()
        {

        }
        public mailfolder(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size)
        {

            Id = _id;
            To = _to;
            From = _from;
            Subject = _subject;
            Content = _content;
            receivedDate = _receivedData;
            size = _size;

        }

        public override string ToString()
        {
            return string.Format("Id:{0}\nTo:{1}\nFrom:{2}\nSubject:{3}\nContent:{4}\nRecievedDate:{5}\nSize:{6}\n" ,Id , To , From , Subject , Content , receivedDate.ToString
            )
        }
    } }

