Task task = MyAsyncMethod();
await task;

async Task MyAsyncMethod()
{
    //Console.WriteLine("Начало метода");

    SomeAsynchronousOperation();

    SomeSynchronousOperation();
    Thread.Sleep(2500);
}

void SomeSynchronousOperation(){
    Console.WriteLine("синхронная операция");
}


async Task SomeAsynchronousOperation()
{
    await Task.Delay(2000);
    Console.WriteLine("асинхронная операция 4 секунды");
}