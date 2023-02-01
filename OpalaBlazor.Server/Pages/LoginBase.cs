using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Authentication;
using OpalaBlazor.Server.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Server.Pages
{
    public class LoginBase : ComponentBase
    {
        [Inject]
        public IUsuarioService userService { get; set; }
        [Inject]
        public IJSRuntime js { get; set; }
        [Inject]
        public AuthenticationStateProvider authStateProvider { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }

        public Model model = new Model();

        public UsuarioDto userAccount = new UsuarioDto();

        public class Model
        {
            public string UserName { get; set; }
            [Required(ErrorMessage = "Login não pode ficar em branco.")]
            public string Login { get; set; }
            [Required(ErrorMessage = "Senha não pode ficar em branco.")]
            public string Password { get; set; }
        }

        public async void Authenticate()
        {
            userAccount = await userService.GetOneLogin(model.Login);

            if (userAccount == null || userAccount.Senha != model.Password)
            {
                await js.InvokeVoidAsync("alert", "Login ou Usuário Inválido.");
                return;
            }

            var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
            await customAuthStateProvider.UpdateAuthenticationState(new UserSession
            {
                UserName = userAccount.Nome,
                Login = userAccount.Login,
                Role = userAccount.Cargo
            });
            navManager.NavigateTo("/", true);
        }
    }
}
