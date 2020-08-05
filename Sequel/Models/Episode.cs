namespace Sequel.Models
{
    public class Episode
    {
        public int EpisodeId { get; set; }

        public string Title { get; set; }

        public int EpisodeNumber { get; set; }

        public string Overview { get; set; }

        public int SeasonId { get; set; }

        public Season Season { get; set; }
    }
}