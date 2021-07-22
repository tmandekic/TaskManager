using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Shared
{
    public class TaskItem
    {
        [Required(ErrorMessage ="Please enter task name")]
        public string TaskName { get; set; }
        
        [Required(ErrorMessage ="Please enter date that the task is due by")]
        [DataType(DataType.Date, ErrorMessage ="Please enter valid date")]
        public DateTime DueBy { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsEditing { get; set; }
        public int Id { get; set; }

    }
}
