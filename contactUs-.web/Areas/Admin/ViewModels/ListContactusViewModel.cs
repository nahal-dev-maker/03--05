namespace contactUs.web.Areas.Admin.ViewModels;

public class ListContactusViewModel
{
    public int Id { get; set; }
    
    public string Email { get; set; }
    
    public string firstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Mobile { get; set; }
    
    public string Title { get; set; }
    
    public string Description { get; set; }

    public DateTime submitDateTime { get; set; }
}