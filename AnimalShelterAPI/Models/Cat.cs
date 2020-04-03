using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelterAPI.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
  }
}