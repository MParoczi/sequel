using System.Collections.Generic;

namespace Sequel.Models
{
    public class Season
    {
        public int SeasonId { get; set; }

        public int SeasonNumber { get; set; }

        public string Name { get; set; }

        public string Overview { get; set; }

        public int ShowId { get; set; }

        public Show Show { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}