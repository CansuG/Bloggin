using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace BLogLab.Services
{
    public interface IPhotoService
    {
        public Task<ImageUploadResult> AddPhotosAsync(IFormFile file);

        public Task<ImageUploadResult> DeletePhotosAsync(string publicId);   
    }
}