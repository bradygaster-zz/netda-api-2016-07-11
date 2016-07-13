using System.Collections.Generic;

namespace TrackPack.Rest.Models
{
    public class Instrument
    {
        public string Name { get; set; }
        public string Device { get; set; }
        public string Preset { get; set; }
    }

    public class Song
    {
        public string Name { get; set; }
        public int Bpm { get; set; }
        public IEnumerable<Instrument> Instruments { get; set; }
    }
}