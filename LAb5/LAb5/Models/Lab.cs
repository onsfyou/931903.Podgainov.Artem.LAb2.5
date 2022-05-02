using System.ComponentModel.DataAnnotations;

namespace LAb5.Models
{
    public class Lab
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
    }
}
