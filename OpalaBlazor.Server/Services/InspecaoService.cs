using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Pages;
using OpalaBlazor.Server.Services.Contracts;

namespace OpalaBlazor.Server.Services
{
    public class InspecaoService : IInspecaoService
    {
        private readonly HttpClient httpClient;

        public InspecaoService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<InspecaoDto>> GetListAll()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/inspecoes/ListAll");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<InspecaoDto>();
                    }
                    return await response.Content.ReadFromJsonAsync<IEnumerable<InspecaoDto>>();
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
