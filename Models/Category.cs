
namespace LikeToDo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public IEnumerable<Task> Tasks { get; set; }
    }
}