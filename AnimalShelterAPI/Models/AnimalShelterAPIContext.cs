using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }

    public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options) : base(options) { }

  }

}