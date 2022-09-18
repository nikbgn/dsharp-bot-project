namespace dsharp_bot_project.Modules
{
    using DSharpPlus.CommandsNext;
    using DSharpPlus.CommandsNext.Attributes;
    using dsharp_bot_project.Commands.GreetingCommands;

    public class GreetingModule : BaseCommandModule
    {

        [Command("sayhello")]
        [Description("A command that says hello.")]
        public async Task SayHello(CommandContext ctx)
            => await SayHelloCommand.SayHello(ctx);

        [Command("saywelcome")]
        [Description("A command that welcomes you.")]
        public async Task SayWelcome(CommandContext ctx)
            => await SayWelcomeCommand.SayWelcome(ctx);
    }
}
