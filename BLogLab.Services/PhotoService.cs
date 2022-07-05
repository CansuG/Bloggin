using BlogLabModels.Settings;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace BLogLab.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly Cloudinary _cloudinary;

        public PhotoService(IOptions<CloudinaryOptions> config)
        {
            var account = new Account(config.Value.CloudName, config.Value.ApiKey, config.Value.ApiSecret);
            
            _cloudinary = new Cloudinary(account);
        }
        public async Task<ImageUploadResult> AddPhotosAsync(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();
            
            if(file.Length > 0)
            {
                using(var stream = file.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams
                    {
                        File = new FileDescription(file.FileName, stream),
                        Transformation = new Transformation().Height(300).Width(500).Crop("fill")
                    };

                    uploadResult = await _cloudinary.UploadAsync(uploadParams);
                }
            }

            return uploadResult;
        }

        public async Task<DeletionResult> DeletePhotosAsync(string publicId)
        {
            var deletionParams = new DeletionParams(publicId);

            var result = await _cloudinary.DestroyAsync(deletionParams);

            return result;

        }
    }
}
