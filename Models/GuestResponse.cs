using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Введите Ваше имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите Ваш email адрес")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите Ваш номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Выберите вариант")]
        public bool? WillAttend { get; set; }
    }
}
