using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContactUs.dal.ViewModels;

public class RegisterViewModel
{
    [DisplayName("ایمیل")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [EmailAddress(ErrorMessage = "{0} وارد شده صحیح نمیباشد")]
    [MaxLength(150,ErrorMessage = "{0} وارد شده نمیتواند بیش از 150 کاراکتر داشته باشد")]

    public string Email { get; set; }
     
    [DisplayName("نام")]
    [MaxLength(150,ErrorMessage = "{0} وارد شده نمیتواند بیش از 150 کاراکتر داشته باشد")]
    public string? Firstname { get; set; }
     
    [DisplayName("نام خانوادگی")]
    [MaxLength(150,ErrorMessage = "{0} وارد شده نمیتواند بیش از 150 کاراکتر داشته باشد")]
    public string? Lastname { get; set; }
     
    [DisplayName("پسوورد")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(150,ErrorMessage = "{0} وارد شده نمیتواند بیش از 150 کاراکتر داشته باشد")]
    public string password { get; set; }
     
    [DisplayName("موبایل")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(150,ErrorMessage = "{0} وارد شده نمیتواند بیش از 150 کاراکتر داشته باشد")]
    public string mobile { get; set; }
}