namespace dsharp_bot_project.Commands.MiscellaneousCommands
{
    using DSharpPlus.CommandsNext;

    public class RandomTriviaFactCommand
    {
        private static string triviaFactsApiURL = "http://numbersapi.com/random/trivia";

        public static async Task ShowTriviaFact(CommandContext ctx)
        {
            string triviaFact = await GetTriviaFactAsync();
            string message = !string.IsNullOrEmpty(triviaFact) ?
                string.Format(GlobalConstants.TRIVIA_MESSAGE_SUCCESS, new string[] {triviaFact,triviaFactsApiURL}) :
                GlobalConstants.MESSAGE_ERROR;
            await ctx.RespondAsync(message);
        }

        public static async Task<string> GetTriviaFactAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(triviaFactsApiURL);
            if (response.IsSuccessStatusCode)
            {
                string fact = await response.Content.ReadAsStringAsync();
                return fact;
            }
            return null;
        }
    }
}
