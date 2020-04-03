using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelterAPI.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    public string Name{ get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
  }
}