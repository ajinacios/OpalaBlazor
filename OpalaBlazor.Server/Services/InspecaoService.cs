using Newtonsoft.Json;
using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Pages;
using OpalaBlazor.Server.Services.Contracts;
using System.Collections.Generic;

namespace OpalaBlazor.Server.Services
{
    public class InspecaoService : IInspecaoService
    {
        private readonly HttpClient httpClient;

        public InspecaoService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<InspecaoDto>> GetListAll()
        {
            List<InspecaoDto> inspecoes = new List<InspecaoDto>();

            try
            {
                var response = await this.httpClient.GetAsync("api/inspecoes");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    inspecoes = JsonConvert.DeserializeObject<List<InspecaoDto>>(content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<InspecaoDto>();
                    }
                    return inspecoes;
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<InspecaoDto> GetOneId(int id)
        {
            //var response = await httpClient.GetAsync($"api/usuarios/porid/{id}");
            var response = await httpClient.GetFromJsonAsync<InspecaoDto>($"api/inspecoes/porid/{id}");
            if (response != null)
            {
                return response;
            }
            else
            {
                var message = "nulo";
                //var message = await response.Content.ReadAsStringAsync();
                throw new Exception(message);
            }
        }

        public async Task<InspecaoDto> GetOneNumero(string numero)
        {
            if (numero.Length < 6)
            {
                return new InspecaoDto();
            }
            numero = numero.Substring(0, numero.Length - 5) + numero.Substring(numero.Length - 4);
            
            try
            {
                var response = await httpClient.GetFromJsonAsync<InspecaoDto>($"api/inspecoes/pornumero/{numero}");
                if (response != null)
                {
                    return response;
                    
                }
                else
                {
                    var message = "nulo";
                    //var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
