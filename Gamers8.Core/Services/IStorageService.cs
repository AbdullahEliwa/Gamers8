namespace Gamers8.Core.Services;

public interface IStorageService
{
    Task<string> SaveAsync(string targetFile, byte[] file, string fileName);

    Task DeleteAsync(string location, string fileId);

    Task<byte[]> DownloadAsync(string container, string fileId);
}