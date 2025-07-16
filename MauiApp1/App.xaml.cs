using MauiApp1.Features.Login.Views;

namespace MauiApp1
{
    public partial class App : Application
    {
        private readonly IServiceProvider _services;

        public App(IServiceProvider services)
        {
            _services = services;
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var shell = new AppShell();

            Task.Run(async () =>
            {
                await shell.GoToAsync($"//{nameof(LoginPage)}");
            });

            return new Window(shell);
        }
    }
}