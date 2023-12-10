using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Download();
            //CallTestmethod();
            Console.WriteLine("After download");
            Console.ReadLine();

        }
        //1st Use Case
        static async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://www.rouxacademy.com");
            //This will execute without the completion of the previous line.
            Console.WriteLine("It's async ");
            Console.WriteLine("hello after download" + data);
            //This console will only print once the value
            //is there in the data variable.
        }
        //2nd Use Case
        static async void CallTestmethod()
        {
            Console.WriteLine("We are in the method");
            Task<long> task = new Task<long>(test);
            task.Start();
            long counterValue = await task;
            Console.WriteLine("We can't wait as it's Async");
            Console.WriteLine("The value of counter is:" + counterValue.ToString());
            //return counterValue;

        }
        static long test()
        {
            long counter = 1;
            for(long i = 0; i<5000000000; i++)
            {
                counter = counter + 1;
                //Thread.Sleep(5000);
            }
            return counter;
        }
       
    }
}
