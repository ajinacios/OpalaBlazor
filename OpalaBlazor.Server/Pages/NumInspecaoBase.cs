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
        public IPessoaJurService pjService { get; set; }
        [Inject]
        public IPessoaFisService pfService { get; set; }
        [Inject]
        public IServidorService servidorService { get; set; }
        [Inject]
        public IJSRuntime js { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }

        public InspecaoDto inspecao = new InspecaoDto();
        public List<InspecaoDto> inspecoes = new List<InspecaoDto>();
        public List<PessoaJurDto> pjs = new List<PessoaJurDto>();
        public List<PessoaFisDto> pfs = new List<PessoaFisDto>();
        public List<ServidorMinDto> servidores = new List<ServidorMinDto>();

        public bool detalhe = false;

        // -----------------------
        public Filtro filtro = new Filtro();

        public class Filtro
        {
            public string Texto { get; set; }
        }
        //---------------------

        protected override async Task OnInitializedAsync()
        {
            inspecoes = (List<InspecaoDto>)await inspecaoService.GetListAll();
            pjs = (List<PessoaJurDto>)await pjService.GetListAll();
            pfs = (List<PessoaFisDto>)await pfService.GetListAll();
            servidores = (List<ServidorMinDto>)await servidorService.GetListAllMin();
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

