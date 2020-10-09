using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace VuonSenDaShop.Application.Common
{
    //IStorageService có nhiệm vụ là save file và lấy thông tin của file
    public interface IStorageService
    {
        string GetFileUrl(string fileName);
        Task SaveFileAsync(Stream mediaBinaryStream, string fileName);
        Task DeleteFileAsync(string fileName);
    }
}
