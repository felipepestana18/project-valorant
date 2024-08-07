using Microsoft.EntityFrameworkCore;

namespace valorant_app_api.Model
{

    [Keyless]
    public class TOP3Agent
    {
        public int TotalKills { get; set; }

        public int MediaKilss { get; set; }

        public string Name { get; set; }

        public string BodyImgURL { get;   set; }
    }
}
