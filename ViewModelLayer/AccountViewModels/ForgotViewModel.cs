using System.ComponentModel.DataAnnotations;

namespace ViewModelLayer.AccountViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}