
using System.ComponentModel.DataAnnotations;

namespace LikeToDo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}