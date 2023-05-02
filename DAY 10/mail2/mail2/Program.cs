using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mail2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the folder:");
            string name = Console.ReadLine();
            mailfolder mf = new mailfolder();
            mail m = new mail();


            while (true)
            {
                {
                    Console.WriteLine("1.Add Mail\n2.Delete Mail\n3.Display Mails\n4.Exit\nEnter your choice");
                    int a = int.Parse(Console.ReadLine());



                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("enter the details of mail in the csv format:");
                            string details = Console.ReadLine();
                            m = mail.CreateMail(details);
                            mf.AddMailFolder(m);

                            Console.WriteLine("mail successfully added");
                            break;
                        case 2:
                            mf.RemoveMailFromFolder(m.Id);
                            Console.WriteLine("enter the id of the mail to be deleted");
                            break;
                        case 3:
                           

                            mf.DisplayMails();
                            break;
                       

                    }
                }


            }

        }
    }
}
