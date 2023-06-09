using System.ComponentModel.DataAnnotations;
namespace ProjectPractise.Models
{
    public class Contact
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Необходимо ввести имя")]
        public string Name { get; set; }
        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Необходимо ввести фамилию")]
        public string Surname { get; set; }
        [Display(Name = "Укажите ваш возраст")]
        public int Age { get; set; }
        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Необходимо ввести почту")]
        public string Email { get; set; }
        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Необходимо ввести сообщение")]
        public string Message { get; set; }
    }
}
