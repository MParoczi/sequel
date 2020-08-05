using System;
using System.Collections.Generic;

namespace Sequel.Models
{
    public class Actor
    {
        public int ActorId { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime Death { get; set; }

        public string Biography { get; set; }

        public List<ShowCharacter> ShowCharacters { get; set; }
    }
}