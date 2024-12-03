using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryInventory.DAL.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        public string Author { get; set; }

        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; }

        [Required]
        public int PublicationYear { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
