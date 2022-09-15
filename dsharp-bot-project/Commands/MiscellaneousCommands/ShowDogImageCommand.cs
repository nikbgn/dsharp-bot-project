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
            var result = await GetImage();
            string message = string.IsNullOrEmpty(result)?
                "There was an error, please try again later...":
                $"**Note: You can use this command only 3 times per hour!**\nThe images are provided by : \"https://dog.ceo/dog-api/\"\n {result}";

            await ctx.RespondAsync(message);
        }

        private async static Task<string> GetImage()
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
