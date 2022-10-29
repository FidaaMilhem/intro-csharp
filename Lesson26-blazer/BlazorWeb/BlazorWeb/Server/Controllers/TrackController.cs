using BlazorWeb.Server.Data;
using BlazorWeb.Server.Model;
using BlazorWeb.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : Controller
    {
        private MusicContext musicContext;


        public TrackController(MusicContext musicContext)
        {
            this.musicContext = musicContext;
        }
        // GET: api/<Track>
        [HttpGet]

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/<Track>
        [HttpGet("{albumId}")]
        public List<TrackResponse> Get(int albumId)
        {
            var tracks = from track in musicContext.Track
                         where track.AlbumId == albumId
                         select new TrackResponse(track.Name, track.TrackId);

            return tracks.ToList();
            
        }
     
        
    }
}
