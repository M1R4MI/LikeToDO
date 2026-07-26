using System.ComponentModel.DataAnnotations;

namespace LikeToDo.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; } = String.Empty;

        public string? CategoryName { get; set; } = String.Empty;

        [MaxLength(400)]
        public string Description { get; set; } = String.Empty;
        public int? CategoryId { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime? DueTo { get; set; }
    }
}