using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Server.Services.Contracts
{
    public interface IServidorService
    {
        Task<List<ServidorDto>> GetListAll();
        Task<List<ServidorMinDto>> GetListAllMin();
        Task<ServidorDto> GetOneId(int id);
        Task<ServidorDto> GetOneNome(string nome);
        Task<ServidorDto> GetOneMatricula(string matr);
        Task<ServidorDto> GetOneEMail(string email);
    }
}
