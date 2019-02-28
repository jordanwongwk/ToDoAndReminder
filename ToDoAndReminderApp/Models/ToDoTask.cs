using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoAndReminderApp.Models
{
    public class ToDoTask
    {
        public int ToDoTaskID { get; set; }
        public string TaskTitle { get; set; }
        public string TaskContent { get; set; }
        public bool IsTaskDone { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TaskReminderDateTime { get; set; }
    }
}
