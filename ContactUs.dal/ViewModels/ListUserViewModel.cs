namespace ContactUs.dal.ViewModels;

public class ListUserViewModel
{
    public int Id { get; set; }
    
    public string Email { get; set; }
     
    public string? Firstname { get; set; }
     
    public string? Lastname { get; set; }
     
    public string password { get; set; }
     
    public string mobile { get; set; }
    public DateTime registerDatetime { get; set; }
}