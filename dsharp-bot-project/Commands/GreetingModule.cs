namespace dsharp_bot_project.Commands
{
    using DSharpPlus.CommandsNext;
    using DSharpPlus.CommandsNext.Attributes;

    public class GreetingModule : BaseCommandModule
    {
        [Command("sayhello")]
        public async Task SayHello(CommandContext ctx)
            => await ctx.RespondAsync("Hello there!");

        [Command("saywelcome")]
        public async Task SayWelcome(CommandContext ctx)
            => await ctx.RespondAsync("Welcome and thank you for executing this command!");
    }
}
