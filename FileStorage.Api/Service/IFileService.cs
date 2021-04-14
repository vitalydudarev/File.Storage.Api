using System.Threading.Tasks;
using FileStorage.Api.Models;

namespace FileStorage.Api.Service
{
    public interface IFileService
    {
        Task<OutgoingFile> SaveAsync(string fileName, byte[] fileContents);
        Task<byte[]> GetFileContentsAsync(long fileId);
        Task<OutgoingFileInfo> GetFileInfoAsync(long fileId);
        Task<OutgoingFileInfo> GetFileInfoByFileNameAsync(string fileName);
        Task DeleteFileAsync(long fileId);
        Task DeleteAllFilesAsync();
    }
}
