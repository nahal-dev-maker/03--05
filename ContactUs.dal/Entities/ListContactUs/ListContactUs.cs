using System.ComponentModel.DataAnnotations;

namespace ContactUs.dal.Entities.ListContactUs;

public class ListContactUs
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(150)]
    public string Email { get; set; }
    
    [MaxLength(150)]
    public string firstName { get; set; }
    
    [MaxLength(150)]
    public string LastName { get; set; }
    
    [MaxLength(20)]
    public string Mobile { get; set; }
    
    [MaxLength(150)]
    public string Title { get; set; }
    
    public string Description { get; set; }

    public DateTime submitDateTime { get; set; }
}