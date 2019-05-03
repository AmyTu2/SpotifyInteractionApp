using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotifyApp.Models
{
    public class Song
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public string Album { get; set; }
    }
}