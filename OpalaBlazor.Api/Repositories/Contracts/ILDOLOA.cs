using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface ILDOLOA
    {
        Task<IEnumerable<LDOLOA>> GetAll();
        Task<LDOLOA> GetOne(int id);
        Task<LDOLOA> Add(LDOLOA ldoloa);
        Task<LDOLOA> Delete(int id);
        Task<LDOLOA> Update(int id, LDOLOA ldoloa);
    }
}
