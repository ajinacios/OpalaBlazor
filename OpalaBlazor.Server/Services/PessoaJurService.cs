using Newtonsoft.Json;
using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Services.Contracts;

namespace OpalaBlazor.Server.Services
{
    public class PessoaJurService : IPessoaJurService
    {
        private readonly HttpClient httpClient;

        public PessoaJurService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<PessoaJurDto>> GetListAll()
        {
            List<PessoaJurDto> pjs = new List<PessoaJurDto>();

            try
            {
                var response = await this.httpClient.GetAsync("api/pessoasjur");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    pjs = JsonConvert.DeserializeObject<List<PessoaJurDto>>(content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<PessoaJurDto>();
                    }
                    return pjs;
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

        public Task<PessoaJurDto> GetOneCNPJ(string CNPJ)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaJurDto> GetOneId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaJurDto> GetOneNumero(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
