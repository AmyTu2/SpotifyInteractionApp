using SpotifyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpotifyApp.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            Song s = new Song()
            {
                Title = "Boy with Luv",
                Genre = "Kpop",
                Artist = "BTS",
                Duration = 3.49,
                Album = "Map of the Soul: Persona"
            };

            List<Song> so = new List<Song>();
            so.Add(s);
            return View();

            
        }
    }
}