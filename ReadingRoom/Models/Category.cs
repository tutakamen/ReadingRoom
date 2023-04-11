using System.ComponentModel.DataAnnotations;
namespace ReadingRoom.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrderperty { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
