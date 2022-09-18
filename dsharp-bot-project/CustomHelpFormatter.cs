namespace dsharp_bot_project
{
    using DSharpPlus.CommandsNext;
    using DSharpPlus.CommandsNext.Converters;
    using DSharpPlus.CommandsNext.Entities;
    using DSharpPlus.Entities;

    public class CustomHelpFormatter : DefaultHelpFormatter
    {
        public CustomHelpFormatter(CommandContext ctx) : base(ctx)
        {

        }

        public override CommandHelpMessage Build()
        {
            EmbedBuilder.Color = DiscordColor.Violet;
            EmbedBuilder.AddField("Have fun using me!",":)");
            return base.Build();
        }
    }
}
