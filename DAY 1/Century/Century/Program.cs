using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Century
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a year: ");
            
            int year = int.Parse(Console.ReadLine());
            
            
              int y =   (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);

            Console.WriteLine("the century is: " +y);


        }
        }

    }


