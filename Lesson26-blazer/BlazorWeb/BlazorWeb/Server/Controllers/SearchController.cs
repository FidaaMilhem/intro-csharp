using BlazorWeb.Server.Data;
using BlazorWeb.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {

        private MusicContext musicContext;


        public SearchController(MusicContext musicContext)
        {
            this.musicContext = musicContext;
        }



        [HttpGet("{Name}")]
        public IEnumerable<SearchResponse> Get(string Name)
        {
            var q = from artist in musicContext.Artist
                    where artist.Name.Contains(Name)
                    select new SearchResponse(artist.Name, artist.ArtistId);

            return  q.ToList();
        }
    }
}
       