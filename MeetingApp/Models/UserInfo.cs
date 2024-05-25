using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{

    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim zorunlu")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon zorunlu")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email alanı")]
        [EmailAddress(ErrorMessage = "Email formatı geçersiz")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Lütfen katılım durumunuzu işaretleyin")]
        public bool? WillAttend { get; set; }
    }
}
