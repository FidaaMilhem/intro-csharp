using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWeb.Shared
{ 
    public record AlbumRespopnse(int id, string title);
    public record TrackResponse(string Name, int Id); 
   
}
