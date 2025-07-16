using MauiApp1.Core.Models;

namespace MauiApp1.Features.Login.Services
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginRequest request);
    }
}
