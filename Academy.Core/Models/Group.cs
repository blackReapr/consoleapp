using System.ComponentModel.DataAnnotations;

namespace Academy.Core.Models;

public class Group
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int Capacity { get; set; }
    public List<Student> Students { get; set; }
}
