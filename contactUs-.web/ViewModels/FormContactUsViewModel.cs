using System.ComponentModel.DataAnnotations;

namespace contactUs.web.ViewModels;

public class FormContactUsViewModel
{


    [Display(Name = "ایمیل")]
    [Required(ErrorMessage ="لطفا{0} را وارد کنید")]
    [MaxLength(150,ErrorMessage = "{0} وارد شده نمیتواند بیش از 150")]
    [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نمیباشد")]

public string Email { get; set; }
    

    [Display(Name = "نامم")]
    [Required(ErrorMessage ="لطفا{0} را وارد کنید")]
    [MaxLength(150,ErrorMessage = "{0} وارد شده نمیتواند بیش از 150")]
    public string firstName { get; set; }
    
    [Display(Name = "نام خانوادگی")]
    [Required(ErrorMessage ="لطفا{0} را وارد کنید")]
    [MaxLength(150,ErrorMessage = "{0} وارد شده نمیتواند بیش از 150")]
    public string LastName { get; set; }
    
        
    [Display(Name = "نام خانوادگی")]
    [Required(ErrorMessage ="لطفا{0} را وارد کنید")]
    [MaxLength(20,ErrorMessage = "{0} وارد شده نمیتواند بیش از 20")]
    public string Mobile { get; set; }
    
        
    [Display(Name = "عنوان ")]
    [Required(ErrorMessage ="لطفا{0} را وارد کنید")]
    [MaxLength(150,ErrorMessage = "{0} وارد شده نمیتواند بیش از 150")]
    public string Title { get; set; }
    
    [Display(Name = "توضیحات ")]
    [Required(ErrorMessage ="لطفا{0} را وارد کنید")]
    public string Description { get; set; }

}