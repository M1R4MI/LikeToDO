
using System.ComponentModel.DataAnnotations;

namespace LikeToDo.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Назва категорії є обов'язковою")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int UserId { get; set; }
        public IEnumerable<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}