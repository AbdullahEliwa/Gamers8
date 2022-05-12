using System.Net;
using Gamers8.Core.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Gamers8.Infrastructure.Services;

public class LocalStorageService : IStorageService
{
    #region CTOR, Fields.
    private readonly IWebHostEnvironment _env;
    public LocalStorageService()
    {

    }

    public Task DeleteAsync(string location, string fileId)
    {
        throw new NotImplementedException();
    }

    public Task<byte[]> DownloadAsync(string container, string fileId)
    {
        throw new NotImplementedException();
    }

    public Task<string> SaveAsync(string targetFile, byte[] file, string fileName)
    {
        throw new NotImplementedException();
    }
    #endregion

    //public async Task<string> SaveAsync(string targetFile, byte[] fileBytes, string fileName)
    //{
    //    var name = Guid.NewGuid() + "." + Path.GetExtension(fileName);
    //    var path = Path.Combine(Directory.GetCurrentDirectory(), targetFile, name);
    //    await using var fileStream = File.Create(path);
    //    await fileStream.WriteAsync(fileBytes);
    //    return name;
    //}


    //public Task DeleteAsync(string container, string fileName) { throw new NotImplementedException(); }
    ////=> Task.Run(() => Delete(_storageLocation.GetPath(container), fileName));



    //public Task<byte[]> DownloadAsync(string container, string fileName)
    //{
    //    var path = Path.Combine(_storageLocation.GetPath(container), fileName);

    //    return File.Exists(path) ? File.ReadAllBytesAsync(path) : throw new FileNotFoundException();
    //}



    //private static async Task<(string fileId, string displayName)> SaveAsync(IFormFile formFile, string directory)
    //{
    //    var untrustedFileName = Path.GetFileName(formFile.Name);
    //    var ext = $"{Path.GetExtension(formFile.FileName).ToLower()}";

    //    if (string.IsNullOrWhiteSpace(directory) ||
    //        string.IsNullOrWhiteSpace(untrustedFileName) ||
    //        formFile.Length == 0)
    //        throw new ArgumentException();

    //    // Create the directory if not exist 
    //    Directory.CreateDirectory(directory);

    //    // Don't trust the file name sent by the client. To display
    //    // the file name, HTML-encode the value.
    //    var trustedFileNameForDisplay = WebUtility.HtmlEncode(formFile.FileName);

    //    var saveName = Guid.NewGuid().ToString("N") + ext;

    //    var path = Path.Combine(directory, saveName);

    //    await using var fileStream = File.Create(path);
    //    await formFile.CopyToAsync(fileStream);

    //    return (saveName, trustedFileNameForDisplay);
    //}
}