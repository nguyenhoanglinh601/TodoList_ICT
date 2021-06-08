using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        [Required]
        public string StartDay { get; set; }
        [Required]
        public string EndDay { get; set; }
        [Column(TypeName="bit")]
        public bool IsComplete { get; set; }
        [Column(TypeName = "bit")]
        public bool IsDisplay { get; set; }
        public string UserId { get; set; }
    }
}
