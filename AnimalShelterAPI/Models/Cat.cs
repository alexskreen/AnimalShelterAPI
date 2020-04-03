using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelterAPI.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
  }
}