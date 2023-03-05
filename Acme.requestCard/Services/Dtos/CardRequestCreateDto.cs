using System.Text.Json.Serialization;

namespace Acme.requestCard.Services.Dtos
{
    public class CardRequestCreateDto: CardRequestInputDto
    {
        [JsonIgnore]
        public override Guid Id { get; set; } = Guid.Empty;
        [JsonIgnore]
        public override string Status { get; set; }
    }
}
