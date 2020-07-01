using AlbumApp.Core.Entities;
using AlbumApp.Core.Interfaces;
using AlbumApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AlbumApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbumService _albumService;

        public HomeController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<IActionResult> Index()
        {
            var albums = await _albumService.GetAlbums();
            ViewBag.albums = albums;
            return View();
        }

        [HttpPost]
        public IActionResult ViewAlbum([FromForm] Album col)
        {
            return RedirectToAction("Index", "Photo", new { col.Id });
        }
    }
}
