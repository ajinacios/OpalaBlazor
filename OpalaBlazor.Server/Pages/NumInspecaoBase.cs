﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Services.Contracts;

namespace OpalaBlazor.Server.Pages
{
    public class NumInspecaoBase : ComponentBase
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
        public IInspecaoServService inspecaoservService { get; set; }
        [Inject]
        public IJSRuntime js { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }

        public InspecaoDto inspecao = new InspecaoDto()
        {
            Numero = GlobalData.inspecao
        };

        public List<InspecaoDto> inspecoes = new List<InspecaoDto>();
        public List<PessoaJurMinDto> pjs = new List<PessoaJurMinDto>();
        public List<PessoaFisMinDto> pfs = new List<PessoaFisMinDto>();
        public List<ServidorMinDto> servidores = new List<ServidorMinDto>();
        public List<InspecaoServAmpDto> inspservs = new List<InspecaoServAmpDto>();
        public List<InspecaoServAmpDto> inspservamps = new List<InspecaoServAmpDto>();

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
            pjs = (List<PessoaJurMinDto>)await pjService.GetListAllMin();
            pfs = (List<PessoaFisMinDto>)await pfService.GetListAllMin();
            servidores = (List<ServidorMinDto>)await servidorService.GetListAllMin();
            inspservs = (List<InspecaoServAmpDto>)await inspecaoservService.GetListAll();
        }

        public async void Detalhar()
        {
            foreach (var inp in inspecoes)
            {
                if (inp.Numero == inspecao.Numero)
                {
                    inspecao = inp;
                    GlobalData.inspecao = inp.Numero;
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
                foreach (var inpserv in inspservs)
                {
                    inspservamps.Clear();
                    if (inpserv.InspecaoId == inspecao.InspecaoId)
                    {
                        inspservamps.Add(new InspecaoServAmpDto()
                        {
                            InspecaoId = inpserv.InspecaoId,
                            ServidorId = inpserv.ServidorId,
                            Matricula = inpserv.Matricula,
                            Nome = inpserv.Nome,
                            Setor = inpserv.Setor,
                            Funcao = inpserv.Funcao
                        });

                    }
                }
                detalhe = true;
            }

        }

        public void onnumero()
        {
            GlobalData.inspecao = "";
            inspecao = new InspecaoDto();
            //foreach (var inp in inspecoes)
            //{
            //    if (inp.Numero == inspecao.Numero)
            //    {
            //        inspecao = inp;
            //        GlobalData.inspecao = inp.Numero;
            //        break;
            //    }
            //}
            detalhe = false;
        }

        protected async Task Counter()
        {
            try
            {
                navManager.NavigateTo("/counter");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

