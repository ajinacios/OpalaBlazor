using Newtonsoft.Json;
using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Services.Contracts;

namespace OpalaBlazor.Server.Services
{
    public class ServidorService : IServidorService
    {
        private readonly HttpClient httpClient;

        public ServidorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<ServidorDto>> GetListAll()
        {
            List<ServidorDto> servidores = new List<ServidorDto>();

            try
            {
                var response = await this.httpClient.GetAsync("api/servidores");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    servidores = JsonConvert.DeserializeObject<List<ServidorDto>>(content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<ServidorDto>();
                    }
                    return servidores;
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

        public Task<ServidorDto> GetOneEMail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ServidorDto> GetOneId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServidorDto> GetOneMatricula(string matr)
        {
            throw new NotImplementedException();
        }

        public Task<ServidorDto> GetOneNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
