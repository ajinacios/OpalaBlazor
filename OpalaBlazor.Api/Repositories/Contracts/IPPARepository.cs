using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IPPARepository
    {
        Task<IEnumerable<PPA>> ListAll();
        Task<PPA> OneId(int id);
        Task<PPA> Add(PPA ppa);
        Task<PPA> Delete(int id);
        Task<PPA> Update(int id, PPA ppa);
    }
}
