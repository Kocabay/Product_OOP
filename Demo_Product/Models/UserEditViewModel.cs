using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lüften isim değeri giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lüften soyisim değeri giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lüften cinsiyet seçiniz")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Lüften mail adresi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lüften şifre giriniz")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lüften şifreyi tekrar giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen Şifrelerin Eşleştiğinden Emin olun.")]
        public string ConfirmPassword { get; set; }
    }
}
