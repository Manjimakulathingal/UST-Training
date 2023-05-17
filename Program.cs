using System.Threading.Tasks;
using System;

class Program
{
    static void Main(string[] args)
    {
        Method1();
        Method2();
        Method3();
        Console.ReadKey();
    }

    public static async Task Method1()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" ozo");
                // Do something
                Task.Delay(100).Wait();
            }
        });
    }


    public static void Method2()
    {
        for (int i = 0; i < 25; i++)
        {
            Console.WriteLine(" ooz");
            // Do something
            Task.Delay(100).Wait();
        }
    }

    public static void Method3()
    {
        for (int i = 0; i < 25; i++)
        {
            Console.WriteLine(" zoo");
            // Do something
            Task.Delay(100).Wait();
        }
    }
}
