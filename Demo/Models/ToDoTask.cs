using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class ToDoTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime CompletedDate { get; set; }
    }
}
