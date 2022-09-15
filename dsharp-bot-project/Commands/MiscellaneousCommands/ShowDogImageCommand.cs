namespace dsharp_bot_project.Commands.MiscellaneousCommands
{
    using DSharpPlus.CommandsNext;
    using Newtonsoft.Json;
    using dsharp_bot_project.Commands.MiscellaneousCommands.DTOs;

    public class ShowDogImageCommand
    {
        private static string dogApiURL = "https://dog.ceo/api/breeds/image/random";

        public static async Task ShowDogImage(CommandContext ctx)
        {
            var result = await GetImageAsync();
            string message = !string.IsNullOrEmpty(result) ?
            string.Format(GlobalConstants.DOG_MESSAGE_SUCCESS, new string[] { dogApiURL, result}) :
            GlobalConstants.MESSAGE_ERROR;

            await ctx.RespondAsync(message);
        }

        private async static Task<string> GetImageAsync()
        {

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(dogApiURL);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.
                    Content.
                    ReadAsStringAsync();

                var dogImageLink = JsonConvert
                    .DeserializeObject<DogImageModel>(json);

                return dogImageLink!.Image;
            }

            return null;

        }
    }
}
