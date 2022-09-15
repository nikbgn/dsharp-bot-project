namespace dsharp_bot_project
{
    using DSharpPlus;
    using Microsoft.Extensions.Logging;

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

            discord.MessageCreated += async (s, e) =>
            {
                //Testing first "command"
                if (e.Message.Content.ToLower().StartsWith("hello") && !e.Message.Author.IsBot)
                {
                    await e.Message.RespondAsync("Hello there!");
                }

            };

            await discord.ConnectAsync();
            await Task.Delay(-1);

        }
    }
}
