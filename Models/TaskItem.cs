using System.ComponentModel.DataAnnotations;

namespace LikeToDo.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; } = String.Empty;

        public int CategoryId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DueTo { get; set; }

        [MaxLength(400)]
        public string Description { get; set; } = String.Empty;
        public bool IsCompleted { get; set; } = false;
        public Category Category { get; set; }
    }
}