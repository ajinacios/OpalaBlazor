using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Server.Services.Contracts
{
    public interface IPessoaJurService
    {
        Task<List<PessoaJurDto>> GetListAll();
        Task<List<PessoaJurMinDto>> GetListAllMin();
        Task<PessoaJurDto> GetOneId(int id);
        Task<PessoaJurDto> GetOneNome(string nome);
        Task<PessoaJurDto> GetOneCNPJ(string CNPJ);
        Task<PessoaJurDto> GetOneEMail(string email);
    }
}
