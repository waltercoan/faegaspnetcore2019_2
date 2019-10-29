using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

namespace myshop.Services
{
    public class StorageService : IStorageService
    {
        private CloudStorageAccount storageAccount;
        public StorageService(  )
        {
            var storageConnectionString = "AQUIVAIASTRINGDECONEXAODOAZURESTORAGE";
            CloudStorageAccount.TryParse(storageConnectionString, out storageAccount);
        }
        public async Task<string> saveFile(IFormFile file)
        {
            if(storageAccount != null){
                CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer cloudBlobContainer = 
                    cloudBlobClient.GetContainerReference("shoppingfaeg");
                //await cloudBlobContainer.CreateIfNotExistsAsync();
                
                string newName = System.Guid.NewGuid().ToString() + file.FileName;
                var cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(newName);
                await cloudBlockBlob.UploadFromStreamAsync(file.OpenReadStream());
                return newName;
            }
            return string.Empty;
        }
    }
}