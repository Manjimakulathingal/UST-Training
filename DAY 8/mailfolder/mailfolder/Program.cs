using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mailfolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter _Id , _To, _From , _Subject , _Content , _receivedData , _size");
            string input = Console.ReadLine();
            string[] arrinput = input.Split(',');
            long Id = long.Parse(arrinput[0]);
            string To = arrinput[1];
            string From = arrinput[2];
            string Subject = arrinput[3];
            string Content = arrinput[4];
            DateTime receivedDate = DateTime.Parse(arrinput[5]);
            double size = long.Parse(arrinput[6]);

            


            Console.WriteLine("enter second _Id , _To, _From , _Subject , _Content , _receivedData , _size");
            string input1 = Console.ReadLine();
            string[] arrinput1 = input.Split(',');
            long Id1 = long.Parse(arrinput[0]);
            string To1 = arrinput[1];
            string From1 = arrinput[2];
            string Subject1 = arrinput[3];
            string Content1 = arrinput[4];
            DateTime receivedDate1 = DateTime.Parse(arrinput[5]);
            double size1 = long.Parse(arrinput[6]);



            
            mailfolder e1 = new mailfolder();
            Console.WriteLine(e1.ToString());
            Equals(Id1, Id, To, To1, From, From1);

            
        }
        public static void Equals(long Id, long Id1, string To, string To1, string From, string From1);





    } }

