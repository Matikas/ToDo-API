using ToDo.Api.Models;

namespace ToDo.Api.DTOs
{
    public class ToDoDto
    {
        public  int Id { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public DateTime? EndDate { get; set; }

        public ToDoDto()
        {

        }

        public ToDoDto(ToDoItem item)
        {
            Id = item.Id;
            UserId = item.UserId;
            Type = item.Type;
            Content = item.Content;
            EndDate = item.EndDate;
        }
    }
}
