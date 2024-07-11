using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace valorant_app_api.Model
{
    public class Match
    {
        public int Id { get; set; }

        public bool Result { get; set; }

        public int Kilss { get; set; }

        public int Death { get; set; }

        public DateTime DateMatch { get; set; }

        public int MapId { get; set; }
        public Map Map { get; set; }

        public int CharactersId { get; set; }
        public Character Characters { get; set; }


    }
}
