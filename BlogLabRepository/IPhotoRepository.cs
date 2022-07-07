using BlogLabModels.Photo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogLab.Repository
{
    public interface IPhotoRepository
    {
        public Task<Photo> InsertAsync(PhotoCreate photoCreate, int applicationUserId);
        public Task<Photo> GetAsync(int photoId);
        public Task<List<Photo>> GetAllByUserIdAsync(int applicationUserId);
        public Task<int> DeleteAsync(int photoId);
    }
}
