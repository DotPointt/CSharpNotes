namespace Program
{
    class Program
    {
        static async void Main()
        {
            await MakeTeaAsync();
        }

        static public string MakeTea()
        {
            var water = BoilWater();

            Console.WriteLine("take the cups out");
            Console.WriteLine("put tea in cups");
            var tea = $"pour {water} in cups";
            Console.WriteLine($"pour {water} in cups");

            return tea;
        }

        static public string BoilWater()
        {
            Console.WriteLine("Start the kettle");


            Console.WriteLine("waiting for the kettle");
            Task.Delay(2000).GetAwaiter().GetResult();

            Console.WriteLine("kettle finished boiling");
            return "boiled water";
        }



        static async public Task<string> MakeTeaAsync()
        {
            var boilingWaterTask = BoilWaterAsync();

            Console.WriteLine("take the cups out");
            Console.WriteLine("put tea in cups");

            var water = await boilingWaterTask;

            var tea = $"pour {water} in cups";
            Console.WriteLine($"pour {water} in cups");

            return tea;
        }

        static async public Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Start the kettle");


            Console.WriteLine("waiting for the kettle");
            await Task.Delay(2000);

            Console.WriteLine("kettle finished boiling");
            return "boiled water";
        }
    }
}







