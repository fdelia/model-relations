using System;
using System.ComponentModel.DataAnnotations;

namespace MvcRelations.Models
{
    public class TodoItemModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Text { get; set; }

        public bool Completed { get; set; }
    }
}