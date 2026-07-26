
using LikeToDo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LikeToDo.Models
{
    public class IndexViewModel
    {
        public IEnumerable<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
        public int? SelectedCategoryId { get; set; }
        public string? SearchQuery { get; set; }

        //Pagination Items
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
    }
}