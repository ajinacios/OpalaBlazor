using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface ILDOLOARepository
    {
        Task<IEnumerable<LDOLOA>> ListAll();
        Task<LDOLOA> OneId(int id);
        Task<LDOLOA> Add(LDOLOA ldoloa);
        Task<LDOLOA> Delete(int id);
        Task<LDOLOA> Update(int id, LDOLOA ldoloa);
    }
}
