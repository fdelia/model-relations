using System;
using System.ComponentModel.DataAnnotations;

namespace MvcRelations.Models
{
    public class Edge
    {
        public Edge(Node node1, Node node2){
            Text = String.Empty;
            Node1 = node1;
            Node2 = node2;
        }

        [Key]
        public int Id { get; set; }
        
        public Node Node1 { get; set; }
        public Node Node2 { get; set; }

        public string Text { get; set; }
    }
}