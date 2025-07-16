using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp1.Core.Models;
using MauiApp1.Features.Login.Services;

namespace MauiApp1.Features.Login.Viewmodels
{
    public partial class LoginViewModel : ObservableRecipient
    {
        private readonly IAuthService _authService;
        public LoginViewModel(IAuthService authService)
        {
            _authService = authService;
        }
        [ObservableProperty]
        private LoginRequest _loginRequest = new LoginRequest();
    }
}
