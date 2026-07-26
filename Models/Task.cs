using System.ComponentModel.DataAnnotations;

namespace LikeToDo.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; } = String.Empty;
        [MaxLength(400)]
        public string Description { get; set; } = String.Empty;
        public int CategoryId { get; set; }
    }
}