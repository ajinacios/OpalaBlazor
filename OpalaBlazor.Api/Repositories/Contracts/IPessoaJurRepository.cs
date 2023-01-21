using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IPessoaJurRepository
    {
        Task<IEnumerable<PessoaJur>> ListAll();
        Task<PessoaJur> OneId(int id);
        Task<PessoaJur> Add(PessoaJur pessoaJur);
        Task<PessoaJur> Delete(int id);
        Task<PessoaJur> Update(int id, PessoaJur pessoaJur);
    }
}
