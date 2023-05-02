using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mail2
{
    internal class mailfolder
    {
        private string _name;
        private List<mail> _mailList;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<mail> mailList
        {
            get { return _mailList; }
            set { _mailList = value; }
        }
        public mailfolder() { }

        public mailfolder(string name , List<mail> mailList)
        {
            _name = name;
            _mailList = mailList;
        }

        public void AddMailFolder(mail mail) 
        {
            _mailList.Add(mail);
        }

        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach (var item in _mailList)

            {
                if(item.Id == id) 
                { 
                    mailList.RemoveAt(count);
                    count = 1;
                    break;
}
            }
            if(count == 1)
            {
                return true;
            }
            else
            {
                   return false;
            }

        }


        public void DisplayMails()
        {
            if(_mailList.Count != 0) 
            {
                Console.WriteLine("mails in inbox");
                foreach (mail mail in _mailList) ;
                Console.WriteLine();

            }
            else { Console.WriteLine("no mails to show");
            }
        }
            
    }
}
