using System;
using System.ComponentModel.DataAnnotations;

namespace MvcRelations.Models
{
    public class TodoItemModel
    {
        public TodoItemModel(){
            Text = String.Empty;
            Completed = false;
        }

        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public bool Completed { get; set; }
    }
}