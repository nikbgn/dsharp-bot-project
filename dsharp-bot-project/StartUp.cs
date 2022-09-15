namespace dsharp_bot_project
{
    internal class StartUp
    {
        static void Main(string[] args)
            => 
            BotSetup
            .Setup()
            .GetAwaiter()
            .GetResult();

    }
}