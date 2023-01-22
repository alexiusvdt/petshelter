using System.Threading.Tasks;
using RestSharp;

namespace PetShelterClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5001/");
      RestRequest request = new RestRequest($"api/animals?PageNumber=1&PageSize=5", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
    
    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5001/");
      RestRequest request = new RestRequest($"api/animals/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async void Post(string newAnimal)
    {
      RestClient client = new RestClient("http://localhost:5001/");
      RestRequest request = new RestRequest($"api/animals", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newAnimal);
      await client.PostAsync(request);
    }

    public static async void Put(int id, string newAnimal)
    {
      RestClient client = new RestClient("http://localhost:5001/");
      RestRequest request = new RestRequest($"api/animals/{id}", Method.Put);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newAnimal);
      await client.PutAsync(request);
    }

    public static async void Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5001/");
      RestRequest request = new RestRequest($"api/animals/{id}", Method.Delete);
      request.AddHeader("Content-Type", "application/json");
      await client.DeleteAsync(request);
    }    

  }
}