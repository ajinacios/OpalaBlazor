using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Authentication;
using OpalaBlazor.Server.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Server.Pages
{
    public class NumInspecaoBase:ComponentBase
    {
        [Inject]
        public IInspecaoService inspecaoService { get; set; }
        [Inject]
        public IJSRuntime js { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }

        public InspecaoDto inspecao = new InspecaoDto();

        public bool detalhe = false;


        public async void Detalhar()
        {
            inspecao = await inspecaoService.GetOneNumero(inspecao.Numero);

            if (inspecao.InspecaoId == 0)
            {
                await js.InvokeVoidAsync("alert", "Inspeção não cadastrada.");
                return;
            }
            else
            {
                detalhe = true;
            }

            
        }
    }
}

