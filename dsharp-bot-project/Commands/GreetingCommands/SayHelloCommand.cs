namespace dsharp_bot_project.Commands.GreetingCommands
{
    using DSharpPlus.CommandsNext;

    public static class SayHelloCommand
    {
        public static async Task SayHello(CommandContext ctx)
            => await ctx.RespondAsync("Hello there!");
    }
}
