using System;
using System.ComponentModel.DataAnnotations;

namespace LuckySpin.Models
{
    public class Player
    {
        [Required(ErrorMessage = "Please enter a valid name.")]
        public string FirstName { get; set; }

        [Required, Range(1, 9, ErrorMessage = "Choose a number")]
        public int Luck { get; set; }
    }
}