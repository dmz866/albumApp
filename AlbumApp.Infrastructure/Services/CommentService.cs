using System.Net.Http;
using System.Threading.Tasks;
using AlbumApp.Core.Entities;
using AlbumApp.Core.Interfaces;
using AlbumApp.Core.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlbumApp.Infrastructure.Services
{
    public class CommentService : ICommentService
    {
        private HttpClient client;
        public async Task<IEnumerable<Comment>> GetComments(int postId)
        {
            client = new HttpClient();
            var response = await client.GetAsync(Constants.JSON_PLACE_HOLDER_URL + "/comments/?postId=" + postId);
            var content = await response.Content.ReadAsStringAsync();
            var comments = JsonConvert.DeserializeObject<IEnumerable<Comment>>(content);
            return comments;
        }
    }
}
