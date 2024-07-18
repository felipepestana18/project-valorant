namespace valorant_app_api.Model
{
    public class MapsApi
    {
        public int status { get; set; }
        public Datum[] data { get; set; }


    }
    public class Datum
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public object narrativeDescription { get; set; }
        public string tacticalDescription { get; set; }
        public string coordinates { get; set; }
        public string displayIcon { get; set; }
        public string listViewIcon { get; set; }
        public string listViewIconTall { get; set; }
        public string splash { get; set; }
        public string stylizedBackgroundImage { get; set; }
        public string premierBackgroundImage { get; set; }
        public string assetPath { get; set; }
        public string mapUrl { get; set; }
        public float xMultiplier { get; set; }
        public float yMultiplier { get; set; }
        public float xScalarToAdd { get; set; }
        public float yScalarToAdd { get; set; }
        public Callout[] callouts { get; set; }
    }

    public class Callout
    {
        public string regionName { get; set; }
        public string superRegionName { get; set; }
        public Location location { get; set; }
    }

    public class Location
    {
        public float x { get; set; }
        public float y { get; set; }
    }


}
