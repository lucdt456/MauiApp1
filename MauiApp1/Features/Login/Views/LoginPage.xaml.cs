using MauiApp1.Features.Login.Viewmodels;

namespace MauiApp1.Features.Login.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel vm)
	{
		InitializeComponent();
	    BindingContext = vm;
    }
}