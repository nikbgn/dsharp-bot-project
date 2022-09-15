namespace dsharp_bot_project.Commands.MiscellaneousCommands.DTOs
{
    using Newtonsoft.Json;

    public class DogImageModel
    {
        [JsonProperty("message")]
        public string Image { get; set; }
    }
}
