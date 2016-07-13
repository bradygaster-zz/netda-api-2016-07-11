using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrackPack.Rest.Models;
using Swashbuckle.SwaggerGen.Annotations;
using Swashbuckle.SwaggerGen.Generator;
using Swashbuckle.Swagger.Model;
using TrackPack.Rest.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TrackPack.Rest.Controllers
{
    [Route("api/[controller]")]
    public class InstrumentController : Controller
    {
        public InstrumentController(IDataService dataService)
        {
            this.DataService = dataService;
        }

        IDataService DataService { get; set; }

        /// <summary>
        /// Gets the list of instruments.
        /// </summary>
        /// <returns>List of instruments.</returns>
        [HttpGet]
        public IEnumerable<Instrument> Get()
        {
            return DataService.GetInstruments();
        }
    }
}
