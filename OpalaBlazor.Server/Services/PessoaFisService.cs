using Newtonsoft.Json;
using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Services.Contracts;

namespace OpalaBlazor.Server.Services
{
    public class PessoaFisService : IPessoaFisService
    {
        private readonly HttpClient httpClient;

        public PessoaFisService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<PessoaFisDto>> GetListAll()
        {
            List<PessoaFisDto> pfs = new List<PessoaFisDto>();

            try
            {
                var response = await this.httpClient.GetAsync("api/pessoasfis");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    pfs = JsonConvert.DeserializeObject<List<PessoaFisDto>>(content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<PessoaFisDto>();
                    }
                    return pfs;
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

        public async Task<List<PessoaFisMinDto>> GetListAllMin()
        {
            List<PessoaFisMinDto> pfs = new List<PessoaFisMinDto>();

            try
            {
                var response = await this.httpClient.GetAsync("api/pessoasfis/minimo");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    pfs = JsonConvert.DeserializeObject<List<PessoaFisMinDto>>(content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<PessoaFisMinDto>();
                    }
                    return pfs;
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

        public Task<PessoaFisDto> GetOneCPF(string CPF)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaFisDto> GetOneEMail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaFisDto> GetOneId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaFisDto> GetOneNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
