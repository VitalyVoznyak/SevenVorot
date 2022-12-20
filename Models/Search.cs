using System.ComponentModel.DataAnnotations;

namespace SevenVorot.Models
{
    public class Search
    {
        [Required(ErrorMessage = "Вам нужно ввести поле")]
        public string searchString { get; set; }
    }
}
