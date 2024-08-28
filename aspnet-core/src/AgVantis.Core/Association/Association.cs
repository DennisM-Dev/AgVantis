using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgVantis.Association
{
    [Table("Associations")]
    public class Associations : FullAuditedEntity
    {
        public const int MaxNameLength = 32;
        public const int MaxEmailAddressLength = 32;

        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }

        [Required]
        [MaxLength(MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }
    }
}
