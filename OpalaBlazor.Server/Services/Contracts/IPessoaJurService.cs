using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Server.Services.Contracts
{
    public interface IPessoaJurService
    {
        Task<List<PessoaJurDto>> GetListAll();
        Task<PessoaJurDto> GetOneId(int id);
        Task<PessoaJurDto> GetOneNumero(string nome);
        Task<PessoaJurDto> GetOneCNPJ(string CNPJ);
    }
}
