namespace dsharp_bot_project
{
    public static class GlobalConstants
    {
        //Discord bot token goes here.
        public const string DISCORD_TOKEN = "BOT_TOKEN_GOES_HERE";



        //Dog image command settings.
        public const int DOG_COMMAND_MAX_USES = 3;
        public const int DOG_COMMAND_RESET_AFTER_ONE_HOUR = 3600;
        public static string DOG_MESSAGE_SUCCESS = 
            $"**Note: You can use this command only {DOG_COMMAND_MAX_USES} times per hour!**\n" +
            "The images are provided by \"{0}\"\n" +
            "{1}";

        //Trivia command settings
        public const int TRIVIA_COMMAND_MAX_USES = 3;
        public const int TRIVIA_COMMAND_RESET_AFTER_ONE_HOUR = 3600;
        public static string TRIVIA_MESSAGE_SUCCESS = 
            $"**Note: You can use this command only {TRIVIA_COMMAND_MAX_USES} times per hour!**\n" +
            "Did you know that: {0}\n" +
            "This fact was provided by {1}";

        //Common command messages
        public const string MESSAGE_ERROR = "There was an error, please try again later...";
    }
}
