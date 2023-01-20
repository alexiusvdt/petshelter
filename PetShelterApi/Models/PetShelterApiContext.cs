using Microsoft.EntityFrameworkCore;

namespace PetShelterApi.Models
{
  public class PetShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public PetShelterApiContext(DbContextOptions<PetShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Name = "Denna", Species = "Cat", SubSpecies = "Himalayan", Age = 7, ShelterDate = "01/20/2023" },
        new Animal { AnimalId = 2, Name = "Kvothe", Species = "Dog", SubSpecies = "Borzoi", Age = 2, ShelterDate = "12/20/2022" },
        new Animal { AnimalId = 3, Name = "Haliax", Species = "Dog", SubSpecies = "Poodle", Age = 5, ShelterDate = "01/03/2023" },
        new Animal { AnimalId = 4, Name = "Bast", Species = "Cat", SubSpecies = "Domestic Shorthair", Age = 5, ShelterDate = "01/10/2023" },
        new Animal { AnimalId = 5, Name = "OreSeur", Species = "Dog", SubSpecies = "Wolfhound", Age = 10, ShelterDate = "12/15/2023" },
        new Animal { AnimalId = 6, Name = "Elend", Species = "Dog", SubSpecies = "Jack Russel Terrier", Age = 4, ShelterDate = "01/10/2023" },
        new Animal { AnimalId = 7, Name = "Kjelvin", Species = "Cat", SubSpecies = "Abyssinian", Age = 3, ShelterDate = "01/18/2023" }
      );
    }
  }
}