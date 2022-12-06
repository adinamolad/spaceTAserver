using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpaceController : ControllerBase
    {
        public static List<LocationNote> _locationNotes = new List<LocationNote>();


        [HttpPost]
        public IEnumerable<LocationNote> Post(LocationNote locationNote)
        {
            _locationNotes.Add(locationNote);
            return _locationNotes.ToArray();
        }

       


    }
}
