using System.Collections.Generic;

namespace Sequel.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        public string Name { get; set; }

        public List<ShowGenre> ShowGenres { get; set; }
    }
}