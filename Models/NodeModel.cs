using System;
using System.ComponentModel.DataAnnotations;

namespace MvcRelations.Models
{
    public class Node
    {
        public Node(){
            Text = String.Empty;
        }

        [Key]
        public int Id { get; set; }

        public string Text { get; set; }
    }
}