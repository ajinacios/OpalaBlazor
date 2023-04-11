using Newtonsoft.Json;
using OpalaBlazor.Models.Dtos;
using OpalaBlazor.Server.Services.Contracts;

namespace OpalaBlazor.Server.Services
{
    public class InspecaoServService : IInspecaoServService
    {
        private readonly HttpClient httpClient;

        public InspecaoServService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<InspecaoServAmpDto>> GetListAll()
        {
            List<InspecaoServAmpDto> inspservs = new List<InspecaoServAmpDto>();

            try
            {
                var response = await this.httpClient.GetAsync("api/inspserv");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    inspservs = JsonConvert.DeserializeObject<List<InspecaoServAmpDto>>(content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<InspecaoServAmpDto>();
                    }
                    return inspservs;
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

        public async Task<List<InspecaoServAmpDto>> GetListInspAmp(int insp)
        {
            List<InspecaoServAmpDto> inspservs = new List<InspecaoServAmpDto>();

            try
            {
                var response = await this.httpClient.GetAsync($"api/inspserv/insp/amp/{insp}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    inspservs = JsonConvert.DeserializeObject<List<InspecaoServAmpDto>>(content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<InspecaoServAmpDto>();
                    }
                    return inspservs;
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

        public async Task<List<InspecaoServidorDto>> GetListInspecao(int insp)
        {
            List<InspecaoServidorDto> inspservs = new List<InspecaoServidorDto>();

            try
            {
                var response = await this.httpClient.GetAsync($"api/inspserv/insp/{insp}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    inspservs = JsonConvert.DeserializeObject<List<InspecaoServidorDto>>(content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<InspecaoServidorDto>();
                    }
                    return inspservs;
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

        public async Task<List<InspecaoServAmpDto>> GetListServAmp(int serv)
        {
            List<InspecaoServAmpDto> inspservs = new List<InspecaoServAmpDto>();

            try
            {
                var response = await this.httpClient.GetAsync($"api/inspserv/serv/amp/{serv}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    inspservs = JsonConvert.DeserializeObject<List<InspecaoServAmpDto>>(content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<InspecaoServAmpDto>();
                    }
                    return inspservs;
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

        public async Task<List<InspecaoServidorDto>> GetListServidor(int serv)
        {
            List<InspecaoServidorDto> inspservs = new List<InspecaoServidorDto>();

            try
            {
                var response = await this.httpClient.GetAsync($"api/inspserv/serv/{serv}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    inspservs = JsonConvert.DeserializeObject<List<InspecaoServidorDto>>(content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<InspecaoServidorDto>();
                    }
                    return inspservs;
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
