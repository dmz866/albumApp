using System;
using System.Threading.Tasks;
using AlbumApp.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AlbumApp.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoService _photoService;
        private readonly ICommentService _commentService;

        public PhotoController(IPhotoService photoService, ICommentService commentService)
        {
            _photoService = photoService;
            _commentService = commentService;
        }
        public async Task<IActionResult> Index()
        {
            int albumId = Convert.ToInt32(RouteData.Values["id"]);
            var photos = await _photoService.GetPhotos(albumId);
            ViewBag.photos = photos;
            return View();
        }

        public async Task<IActionResult> Comments(int postId)
        {
            var comments = await _commentService.GetComments(postId);
            ViewBag.comments = comments;
            return PartialView("Comments");
        }
    }
}
