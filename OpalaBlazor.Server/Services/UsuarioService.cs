using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Services.Contracts;
using System.Net.Http.Json;

namespace OpalaBlazor.Server.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly HttpClient httpClient;

        public UsuarioService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<UsuarioDto>> GetListAll()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/usuarios/ListAll");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<UsuarioDto>();
                    }
                    return await response.Content.ReadFromJsonAsync<IEnumerable<UsuarioDto>>();
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

        public async Task<UsuarioDto> GetOneId(int id)
        {
            try
            {
                //var response = await httpClient.GetAsync($"api/usuarios/porid/{id}");
                var response = await httpClient.GetFromJsonAsync<UsuarioDto>($"api/usuarios/porid/{id}");
                if (response != null)
                {
                    return response;
                    //if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    //{
                    //    return default(UsuarioDto);
                    //}
                    //return await response.Content.ReadFromJsonAsync<UsuarioDto>();
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

        public async Task<UsuarioDto> GetOneLogin(string login)
        {
            try
            {
                var response = await httpClient.GetAsync($"Usuarios/porlogin/{login}");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(UsuarioDto);
                    }
                    return await response.Content.ReadFromJsonAsync<UsuarioDto>();
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
    }
}
