using System.Net.Http;
using System.Threading.Tasks;
using AlbumApp.Core.Entities;
using AlbumApp.Core.Interfaces;
using AlbumApp.Core.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlbumApp.Infrastructure.Services
{
    public class PhotoService : IPhotoService
    {
        private HttpClient client;
        public async Task<IEnumerable<Photo>> GetPhotos(int albumId)
        {
            client = new HttpClient();
            var response = await client.GetAsync(Constants.JSON_PLACE_HOLDER_URL + "/photos/?albumId=" + albumId);
            var content = await response.Content.ReadAsStringAsync();
            var photos = JsonConvert.DeserializeObject<IEnumerable<Photo>>(content);
            return photos;
        }
    }
}
