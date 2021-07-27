using System;
using System.ComponentModel.DataAnnotations;

namespace TechTest.Models
{
    public class NumberList
    {
        //All the propaties of the database
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = ("The number field is required."))]
        public string Numbers { get; set; }
        [Required]
        public string direction { get; set; }
        [Required(ErrorMessage = ("Please choose a sort direction from the dropdown."))]
        public string time { get; set; }
    }
}
