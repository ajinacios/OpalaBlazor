using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IPessoaFisRepository
    {
        IEnumerable<PessoaFis> ListAll();
        Task<PessoaFis> OneId(int id);
        Task<PessoaFis> Add(PessoaFis pessoaFis);
        Task<PessoaFis> Delete(int id);
        Task<PessoaFis> Update(int id, PessoaFis pessoaFis);
    }
}
