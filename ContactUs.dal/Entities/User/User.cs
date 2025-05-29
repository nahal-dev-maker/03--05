using System.ComponentModel.DataAnnotations;

namespace ContactUs.dal.Entities.User;

public class User
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(150)]
    public string Email { get; set; }
     
    [MaxLength(150)]
    public string? Firstname { get; set; }
     
    [MaxLength(150)]
    public string? Lastname { get; set; }
     
    [MaxLength(150)]
    public string password { get; set; }
     
    [MaxLength(150)]
    public string mobile { get; set; }
    public DateTime registerDatetime { get; set; }
   
}