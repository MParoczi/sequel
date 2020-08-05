namespace Sequel.Models
{
    public class ShowGenre
    {
        public int ShowGenreId { get; set; }

        public int ShowId { get; set; }

        public Show Show { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}