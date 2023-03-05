using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Acme.requestCard.Services.Dtos
{
    public abstract class CardRequestInputDto : IEntityDto<Guid>
    {
        public virtual Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerPhone { get; set; }
        [Required]
        [StringLength(100)]
        public string CustomerEmail { get; set; }

        [StringLength(24)]
        [Required]
        public string CustomerAccountNumber { get; set; }

        public string CardType { get; set; }

        [StringLength(100)]
        public string DeliveryAddress { get; set; }

        public virtual string Status { get; set; }
    }
}
