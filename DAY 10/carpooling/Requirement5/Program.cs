using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList li1 = new ArrayList();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter details:");
                string input = Console.ReadLine();
                string[] arr = input.Split(',');
                member member = new member(arr[0] , arr[1] , arr[2]);
                try

                {

                    member.checking(arr[2]);

                }

                catch (InvalidMailException e)

                {

                    e.inform();

                }

                li1.Add(member);
                member.ToString();
                li1.ToString();

            }


        }
    }
}
