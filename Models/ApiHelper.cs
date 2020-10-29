using RestSharp;
using System.Threading.Tasks;

namespace TravelClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:4005/api");
      RestRequest request = new RestRequest($"Reviews", Method.GET);
      request.AddHeader("Authorization", $"Bearer {EnvironmentVariables.ApiKey}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:4005/api");
      RestRequest request = new RestRequest($"Reviews/{id}", Method.GET);
      request.AddHeader("Authorization", $"Bearer {EnvironmentVariables.ApiKey}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newReview)
    {
      RestClient client = new RestClient("http://localhost:4005/api");
      RestRequest request = new RestRequest($"Reviews", Method.POST);
      request.AddHeader("Authorization", $"Bearer {EnvironmentVariables.ApiKey}");
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReview);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newReview)
    {
      RestClient client = new RestClient("http://localhost:4005/api");
      RestRequest request = new RestRequest($"Reviews/{id}", Method.PUT);
      request.AddHeader("Authorization", $"Bearer {EnvironmentVariables.ApiKey}");
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReview);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:4005/api");
      RestRequest request = new RestRequest($"Reviews/{id}", Method.DELETE);
      request.AddHeader("Authorization", $"Bearer {EnvironmentVariables.ApiKey}");
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task<string> GetPopular()
    {
      RestClient client = new RestClient("http://localhost:4005/api");
      RestRequest request = new RestRequest($"Reviews/popular", Method.GET);
      request.AddHeader("Authorization", $"Bearer {EnvironmentVariables.ApiKey}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetRandom()
    {
      RestClient client = new RestClient("http://localhost:4005/api");
      RestRequest request = new RestRequest($"Reviews/random", Method.GET);
      request.AddHeader("Authorization", $"Bearer {EnvironmentVariables.ApiKey}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

  }
}
