using System.ComponentModel.DataAnnotations;

namespace Academy.Core.Models;

public class Student
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public Group group { get; set; }
}
