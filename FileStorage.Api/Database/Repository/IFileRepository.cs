using System.Collections.Generic;
using System.Threading.Tasks;
using FileStorage.Api.Database.Entities;

namespace FileStorage.Api.Database.Repository
{
    public interface IFileRepository
    {
        Task<File> AddAsync(File incomingFile);
        Task<File> GetAsync(long fileId);
        Task<File> GetByFileNameAsync(string fileName);
        Task<IEnumerable<File>> GetAllAsync();
        Task DeleteAsync(long fileId);
        Task DeleteAllAsync();
    }
}
