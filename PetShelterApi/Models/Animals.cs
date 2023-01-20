namespace PetShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public string SubSpecies { get; set; }
    public int Age { get; set; }
    public string ShelterDate { get; set; }
  }
}