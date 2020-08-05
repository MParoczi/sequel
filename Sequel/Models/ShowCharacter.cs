namespace Sequel.Models
{
    public class ShowCharacter
    {
        public int ShowCharacterId { get; set; }

        public int ShowId { get; set; }

        public Show Show { get; set; }

        public int ActorId { get; set; }

        public Actor Actor { get; set; }

        public string CharacterName { get; set; }
    }
}