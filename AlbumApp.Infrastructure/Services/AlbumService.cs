using System.Net.Http;
using System.Threading.Tasks;
using AlbumApp.Core.Entities;
using AlbumApp.Core.Interfaces;
using AlbumApp.Core.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlbumApp.Infrastructure.Services
{
    public class AlbumService : IAlbumService
    {
        private HttpClient client;
        public async Task<IEnumerable<Album>> GetAlbums()
        {
            client = new HttpClient();
            var response = await client.GetAsync(Constants.JSON_PLACE_HOLDER_URL + "/albums");
            var content = await response.Content.ReadAsStringAsync();
            var albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(content);
            return albums;
        }
    }
}
