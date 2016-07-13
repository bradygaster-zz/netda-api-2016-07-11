using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrackPack.Rest.Models;
using Swashbuckle.SwaggerGen.Annotations;
using TrackPack.Rest.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TrackPack.Rest.Controllers
{
    [Route("api/[controller]")]
    public class SongController : Controller
    {
        IDataService DataService { get; set; }

        public SongController(IDataService dataService)
        {
            this.DataService = dataService;
        }

        /// <summary>
        /// Gets the list of songs.
        /// </summary>
        /// <returns>List of songs.</returns>
        [HttpGet]
        [SwaggerOperation("getAllSongs")]
        public IEnumerable<Song> Get()
        {
            return DataService.GetSongs();
        }

        /// <summary>
        /// Create a new song.
        /// </summary>
        /// <param name="song">The song to be created.</param>
        [HttpPost]
        [SwaggerOperation("createSong")]
        [Route("song/createSong")]
        public void Post([FromBody]Song song)
        {
            // todo: implement
        }

        /// <summary>
        /// Add an instrument to an existing song.
        /// </summary>
        /// <param name="instrument">The instrument to be added.</param>
        [HttpPost] 
        [SwaggerOperation("addInstrument")]
        [Route("song/addInstrument")]
        public void AddInstrument([FromBody] Instrument instrument)
        {
            // todo: implement
        }
    }
}
