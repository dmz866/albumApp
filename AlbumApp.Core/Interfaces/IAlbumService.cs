using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AlbumApp.Core.Entities;
namespace AlbumApp.Core.Interfaces
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAlbums();
    }
}
