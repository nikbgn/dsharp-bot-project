namespace dsharp_bot_project.Modules
{
    using DSharpPlus.CommandsNext;
    using DSharpPlus.CommandsNext.Attributes;
    using dsharp_bot_project.Commands.MiscellaneousCommands;

    public class MiscellaneousModule : BaseCommandModule
    {

        [Command("showdogimage")]
        [Cooldown(
            GlobalConstants.DOG_COMMAND_MAX_USES,
            GlobalConstants.DOG_COMMAND_RESET_AFTER_ONE_HOUR,
            CooldownBucketType.User)]
        public async Task ShowDogImage(CommandContext ctx)
            => await ShowDogImageCommand.ShowDogImage(ctx);

    }
}
