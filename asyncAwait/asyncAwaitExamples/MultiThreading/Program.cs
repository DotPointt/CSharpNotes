using System;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var task = asyncmethod();

            Console.WriteLine($"Продолжаем работу в методе Main [{Thread.CurrentThread.ManagedThreadId}]"); 
            Thread.Sleep(2000);
                       
            Console.WriteLine($"Завершаем работу Main [{Thread.CurrentThread.ManagedThreadId}]");

            await task;
        }

        static async Task asyncmethod()
        {
            await Task.Run(() => Console.WriteLine());
            Task.Delay(2000);
            Console.WriteLine("asyncmethod done 1");
            Thread.Sleep(3000);
            Console.WriteLine("asyncmethod done 2");
            
        }

        static void Print()
        {
            Thread.Sleep(3000);
            Console.WriteLine($"Hello! [{Thread.CurrentThread.ManagedThreadId}]");
        }

        static async void PrintAsync()
        {
            Console.WriteLine($"Начало работы PrintAsync [{Thread.CurrentThread.ManagedThreadId}]");
            await Task.Run(() => Print());
            Console.WriteLine($"Конец метода PrintAsync [{Thread.CurrentThread.ManagedThreadId}]");
        }
    }
}


