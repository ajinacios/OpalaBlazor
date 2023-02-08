using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Authentication;
using OpalaBlazor.Server.Services.Contracts;
using System.Collections.Generic;
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

        public List<UsuarioDto> userAccounts = new List<UsuarioDto>();

        public class Model
        {
            public string UserName { get; set; }
            [Required(ErrorMessage = "Login não pode ficar em branco.")]
            public string Login { get; set; }
            [Required(ErrorMessage = "Senha não pode ficar em branco.")]
            public string Password { get; set; }
            public string Cargo { get; set; }
        }

        protected override async Task OnInitializedAsync()
        {
            userAccounts = (List<UsuarioDto>)await userService.GetListAll();
        }

        public async void Authenticate()
        {
            var logado = false;
            foreach(var userAccount in userAccounts)
            {
                if (userAccount.Login == model.Login && userAccount.Senha == model.Password)
                { 
                    logado = true;
                    model.UserName = userAccount.Nome;
                    model.Cargo = userAccount.Cargo;
                    GlobalData.usuario = userAccount.Nome;
                    GlobalData.login = userAccount.Login;
                    break; 
                }
            }

            if (!logado)
            {
                await js.InvokeVoidAsync("alert", "Login ou Usuário Inválido.");
                return;
            }

            var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
            await customAuthStateProvider.UpdateAuthenticationState(new UserSession
            {
                UserName = model.UserName,
                Login = model.Login,
                Role = model.Cargo
            });
            navManager.NavigateTo("/", true);
        }
    }
}
