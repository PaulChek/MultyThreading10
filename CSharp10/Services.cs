using CSharp10.Model;
using System.Net.Http.Json;

namespace CSharp10.Services;

    #region ServerRequest
    public class ServerRequest {
        private readonly HttpClient _httpClient;
        public ServerRequest(HttpClient httpClient) {
            _httpClient = httpClient;
        }
        public  Task<User?> GetJson(int id) => 
            _httpClient.GetFromJsonAsync<User>($"https://jsonplaceholder.typicode.com/users/{id}");
    }
    #endregion