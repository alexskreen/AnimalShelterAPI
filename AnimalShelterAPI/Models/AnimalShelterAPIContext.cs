using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }

    public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dog>()
      .HasData(
        new Dog { DogId = 1, Name = "Casey", Breed = "Golden Retriever", Age = 15 },
        new Dog { DogId = 2, Name = "Brian", Breed = "Flat Coat Retriever", Age = 10 },
        new Dog { DogId = 3, Name = "Frank", Breed = "Golden Retriever", Age = 7 }
      );
      builder.Entity<Cat>()
      .HasData(
        new Cat { CatId = 1, Name = "Stella", Breed = "Polydactyl Turkish Angora", Age = 9 },
        new Cat { CatId = 2, Name = "Charlie", Breed = "Tuxedo", Age = 5 },
        new Cat { CatId = 3, Name = "Tina", Breed = "Tabby", Age = 7 }
      );
    }
  }

}