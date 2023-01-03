using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IPessoaFis
    {
        Task<IEnumerable<PessoaFis>> GetAll();
        Task<PessoaFis> GetOne(int id);
        Task<PessoaFis> Add(PessoaFis pessoaFis);
        Task<PessoaFis> Delete(int id);
        Task<PessoaFis> Update(int id, PessoaFis pessoaFis);
    }
}
