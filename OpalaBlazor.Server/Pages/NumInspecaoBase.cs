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

        public List<InspecaoDto> inspecoes = new List<InspecaoDto>();

        public bool detalhe = false;

        protected override async Task OnInitializedAsync()
        {
            inspecoes = (List<InspecaoDto>)await inspecaoService.GetListAll();
        }

        public async void Detalhar()
        {
            foreach(var inp in inspecoes)
            {
                if (inp.Numero == inspecao.Numero)
                {
                    inspecao = inp;
                    break;
                }
            }

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

