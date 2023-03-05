using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Domain.Repositories;

namespace Acme.requestCard.Entities
{
    [Table("sec_bank_card_request")]
    public class CardRequestEntity: Abp.Domain.Entities.Auditing.AuditedEntity<Guid>
    {
        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerPhone { get; set; }
        [StringLength(100)]
        public string CustomerEmail { get; set; }

        [StringLength(24)]
        public string CustomerAccountNumber { get; set; }

        public string CardType { get; set; }

        [StringLength(100)]
        public string DeliveryAddress { get; set; }
        public string Status { get; set; }
    }
}
