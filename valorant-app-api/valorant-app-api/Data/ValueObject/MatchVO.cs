using valorant_app_api.Model;

namespace valorant_app_api.Data.ValueObject
{
    public class MatchVO
    {


        public bool Result { get; set; }

        public int Kilss { get; set; }

        public int Death { get; set; }

        public DateTime DateMatch { get; set; }

        public int MapId { get; set; }

        public int CharactersId { get; set; }

    }

    public class MatchReturnVO
    {

        public bool Result { get; set; }

        public int Kilss { get; set; }

        public int Death { get; set; }

        public DateTime DateMatch { get; set; }

        public Map Map { get; set; }

        public CharacterVO Character { get; set; }

    }   
}
