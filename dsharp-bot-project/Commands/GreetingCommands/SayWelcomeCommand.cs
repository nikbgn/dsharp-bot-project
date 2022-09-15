namespace dsharp_bot_project.Commands.GreetingCommands
{
    using DSharpPlus.CommandsNext;

    public class SayWelcomeCommand
    {
        public static async Task SayWelcome(CommandContext ctx)
            => await ctx.RespondAsync("Welcome and thank you for executing this command!");
    }
}
