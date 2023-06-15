using System.ComponentModel.DataAnnotations;

namespace TaskBoardApp.Models.Task
{
    public class MyTaskViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;
      
        public string Description { get; set; } = null!;    

        public string Owner { get; set; } = null!;

    }
}
