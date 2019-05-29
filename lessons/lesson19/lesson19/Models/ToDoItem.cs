using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace lesson19.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        [DisplayName("Задача")]
        public string Title { get; set; }
        [DisplayName("Начало")]
        public DateTime Start { get; set; }
        [DisplayName("Срок")]
        public DateTime End { get; set; }
        [DisplayName("Выполнено")]
        public bool Done { get; set; }
    }
}
