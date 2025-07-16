using MauiApp1.Core.Models;
using MauiApp1.Core.Utils.Helpers;
using Microsoft.Extensions.Options;
using System.Text;
using System.Text.Json;

namespace MauiApp1.Features.Login.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiOptions _apiOptions;

        public AuthService(IOptions<ApiOptions> apiOptions)
        {
            _apiOptions = apiOptions.Value;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_apiOptions.BaseUrl)
            };
        }

        public async Task<string> LoginAsync(LoginRequest request)
        {
            var requestBody = new
            {
                email = request.Email,
                password = request.Password 
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Account/Login", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return "Error: " + response.ReasonPhrase;
            }
        }
    }
}
