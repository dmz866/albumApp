using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AlbumApp.Core.Entities;
namespace AlbumApp.Core.Interfaces
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetComments(int postId);
    }
}
