using System;
using System.ComponentModel.DataAnnotations;

namespace AdminTemplate_User.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please fill Id")]
        [Range(0, int.MaxValue, ErrorMessage = "Please fill integer Number")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please fill Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please choose Date")]
        public DateTime Birthday { get; set; }
        [Required(ErrorMessage = "Please choose Gender")]
        public byte Gender { get; set; }
        [Required(ErrorMessage = "Please fill Class")]
        public string Class { get; set; }
        [Required(ErrorMessage = "Please fill Email")]
        public string Email { get; set; }
    }
}
