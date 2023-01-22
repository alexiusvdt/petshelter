using Microsoft.AspNetCore.Mvc;
using PetShelterClient.Models;

namespace PetShelterClient.Controllers;

public class AnimalsController : Controller
{
public async Task<IActionResult> Index(string sortOrder, string searchString)
{
    List<Animal> animalList = Animal.GetAnimals();
    ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
    ViewData["SpeciesSortParm"] = String.IsNullOrEmpty(sortOrder) ? "species_desc" : "";
    ViewData["SubSpeciesSortParm"] = String.IsNullOrEmpty(sortOrder) ? "subspecies_desc" : "";
    ViewData["AgeSortParm"] = sortOrder == "Age" ? "age_desc" : "Age";
    ViewData["CurrentFilter"] = searchString; 
    var animals = from a in animalList
                   select a;
    if (!String.IsNullOrEmpty(searchString))
    {
      searchString.ToLower();
      animals = animals.Where(s => s.Name.ToLower().Contains(searchString)
                               || s.Species.ToLower().Contains(searchString));
    }
    switch (sortOrder)
    {
        case "name_desc":
            animals = animals.OrderByDescending(s => s.Name);
            break;
        case "species_desc":
            animals = animals.OrderByDescending(s => s.Species);
            break;
        case "Age":
            animals = animals.OrderBy(s => s.Age);
            break;
        case "age_desc":
            animals = animals.OrderByDescending(s => s.Age);
            break;
        default:
            animals = animals.OrderBy(s => s.Name);
            break;
    }
    return View(animals);
}

  public IActionResult Details(int id)
  {
    Animal animal = Animal.GetDetails(id);
    return View(animal);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Animal animal)
  {
    Animal.Post(animal);
    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    Animal animal = Animal.GetDetails(id);
    return View(animal);
  }

  [HttpPost]
  public ActionResult Edit(Animal animal)
  {
    Animal.Put(animal);
    return RedirectToAction("Details", new { id = animal.AnimalId});
  }

  public ActionResult Delete(int id)
  {
    Animal animal = Animal.GetDetails(id);
    return View(animal);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Animal.Delete(id);
    return RedirectToAction("Index");
  }
}