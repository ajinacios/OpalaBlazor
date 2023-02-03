using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Server.Services.Contracts
{
    public interface IPessoaFisService
    {
        Task<List<PessoaFisDto>> GetListAll();
        Task<PessoaFisDto> GetOneId(int id);
        Task<PessoaFisDto> GetOneNome(string nome);
        Task<PessoaFisDto> GetOneCPF(string CPF);
        Task<PessoaFisDto> GetOneEMail(string email);
    }
}
