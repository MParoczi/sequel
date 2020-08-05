using System;
using System.Collections.Generic;

namespace Sequel.Models
{
    public class Show
    {
        public int ShowId { get; set; }

        public string Title { get; set; }

        public DateTime Year { get; set; }

        public string Overview { get; set; }

        public int Runtime { get; set; }

        public string Trailer { get; set; }

        public string Homepage { get; set; }

        public double Rating { get; set; }

        public List<ShowGenre> ShowGenres { get; set; }

        public List<Season> Seasons { get; set; }

        public List<ShowCharacter> ShowCharacters { get; set; }
    }
}