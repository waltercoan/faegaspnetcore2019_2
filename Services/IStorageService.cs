using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace myshop.Services
{
    public interface IStorageService
    {
         Task<string> saveFile(IFormFile file);
    }
}