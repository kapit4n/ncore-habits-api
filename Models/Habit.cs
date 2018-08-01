using System;
using System.ComponentModel.DataAnnotations;

namespace habitsWebapi.Models
{
  public class Habit
  {
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(20)]
    public string Name { get; set; }
    public string Description { get; set; }

  }
}