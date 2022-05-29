

using System.ComponentModel.DataAnnotations;

namespace SSManagment.Data.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100,MinimumLength =2)]
        public string Name { get; set; }
    }
}
