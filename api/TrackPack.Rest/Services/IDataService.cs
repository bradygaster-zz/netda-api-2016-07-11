using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackPack.Rest.Models;

namespace TrackPack.Rest.Services
{
    public interface IDataService
    {
        IEnumerable<Instrument> GetInstruments();
        IEnumerable<Song> GetSongs();
    }

    public class MockDataService : IDataService
    {
        public IEnumerable<Instrument> GetInstruments()
        {
            return new Instrument[]
            {
                new Instrument
                {
                    Device = "Kaossilator",
                    Preset = "231",
                    Name = "Gate"
                },
                new Instrument
                {
                    Device = "Kaossilator",
                    Preset = "198",
                    Name = "Techno"
                },
                new Instrument
                {
                    Device = "Microkorg",
                    Preset = "A11",
                    Name = "Dissonance"
                }
            };
        }

        public IEnumerable<Song> GetSongs()
        {
            return new Song[]
            {
                new Song
                {
                    Name = "Sunday Drive",
                    Bpm = 91,
                    Instruments = GetInstruments()
                },
                new Song
                {
                    Name = "Impromptu Jam Session",
                    Bpm = 123,
                    Instruments = GetInstruments().Where(x => x.Device == "Microkorg")
                }
            };
        }
    }
}
