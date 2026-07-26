using Microsoft.AspNetCore.Mvc.Rendering;

namespace LikeToDo.Models
{
    public static class Data
    {
        // Тестові категорії
        public static List<SelectListItem> GetMockCategories()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Робота" },
                new SelectListItem { Value = "2", Text = "Особисті справи" },
                new SelectListItem { Value = "3", Text = "Навчання" }
            };
        }

        // Тестові завдання
        public static List<TaskItem> GetMockTasks()
        {
            return new List<TaskItem>
            {
                new TaskItem 
                { 
                    Id = 1, 
                    Name = "Спроєктувати базу даних", 
                    CategoryId = 1, 
                    CategoryName = "Робота", 
                    IsCompleted = true, 
                    DueTo = DateTime.Now.AddDays(-2) 
                },
                new TaskItem 
                { 
                    Id = 2, 
                    Name = "Виправити NullReferenceException у View", 
                    CategoryId = 1, 
                    CategoryName = "Робота", 
                    IsCompleted = false, 
                    DueTo = DateTime.Now 
                },
                new TaskItem 
                { 
                    Id = 3, 
                    Name = "Купити молоко та хліб", 
                    CategoryId = 2, 
                    CategoryName = "Особисті справи", 
                    IsCompleted = false, 
                    DueTo = DateTime.Now.AddDays(1) 
                },
                new TaskItem 
                { 
                    Id = 4, 
                    Name = "Записатися до стоматолога", 
                    CategoryId = 2, 
                    CategoryName = "Особисті справи", 
                    IsCompleted = false, 
                    DueTo = DateTime.Now.AddDays(5) 
                },
                new TaskItem 
                { 
                    Id = 5, 
                    Name = "Прочитати документацію EF Core", 
                    CategoryId = 3, 
                    CategoryName = "Навчання", 
                    IsCompleted = false, 
                    DueTo = DateTime.Now.AddDays(3) 
                },
                new TaskItem 
                { 
                    Id = 6, 
                    Name = "Завдання без категорії", 
                    CategoryId = null, 
                    CategoryName = null, 
                    IsCompleted = false, 
                    DueTo = null 
                }
            };
        }
    }
}