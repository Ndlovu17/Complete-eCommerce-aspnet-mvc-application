using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class BaseCls
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string ProfilePictureURL { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(255)]
        public string Bio { get; set; }
    }
}
