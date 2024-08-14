using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public partial class TEMPLATE_ENTITY_CLASS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EndUserId { get; set; }
      
        [MaxLength]
        public string? UserEmail { get; set; }

        [MaxLength(80)]
        public string? FirstName { get; set; }

        [MaxLength(80)]
        public string? LastName { get; set; }

    }
}
