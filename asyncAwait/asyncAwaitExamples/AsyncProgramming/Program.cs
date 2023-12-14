using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var task = SomeAsynchronousOperation(); // Сразу исполняется

            //SomeAsynchronousOperation();
            SomeSynchronousOperation();

            await task; //вместо Thread.Sleep(3000);
        }


        static void SomeSynchronousOperation()
        {
            Console.WriteLine("синхронная операция");
        }


        async static Task SomeAsynchronousOperation()
        {
            await Task.Delay(2000); //почему если использовать .Wait(); то асинхронности не будет?
            Console.WriteLine("асинхронная операция 2 секунды");
        }
    }
}


