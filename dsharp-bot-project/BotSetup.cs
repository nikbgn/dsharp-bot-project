namespace dsharp_bot_project
{
    using DSharpPlus;
    using DSharpPlus.CommandsNext;
    using Microsoft.Extensions.Logging;
    using dsharp_bot_project.Commands;

    public static class BotSetup
    {
        public static async Task Setup()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = GlobalConstants.DISCORD_TOKEN,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged,
                MinimumLogLevel = LogLevel.Debug,
                LogTimestampFormat = "dd MMM yyyy - HH:mm:ss tt"


            });

            var commands = 
                discord.UseCommandsNext(new CommandsNextConfiguration()
                {
                    StringPrefixes = new[] {"&"} 
                });

            commands.RegisterCommands<GreetingModule>();


            await discord.ConnectAsync();
            await Task.Delay(-1);

        }
    }
}
