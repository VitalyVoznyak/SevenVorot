using System.ComponentModel.DataAnnotations;

namespace SevenVorot.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Вам нужно ввести поле")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Вам нужно ввести поле")]
        public string Surame { get; set; }
        [Required(ErrorMessage = "Вам нужно ввести поле")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Вам нужно ввести поле")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Вам нужно ввести поле")]
        public string Message { get; set; }

    }
}
