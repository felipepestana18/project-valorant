using Newtonsoft.Json;

namespace valorant_app_api.Model
{
}
public class Rootobject
{
    public int status { get; set; }
    public Datum[] data { get; set; }
}

public class Datum
{
    public string uuid { get; set; }
    public string displayName { get; set; }
    public string description { get; set; }
    public string developerName { get; set; }
    public string[] characterTags { get; set; }
    public string displayIcon { get; set; }
    public string displayIconSmall { get; set; }
    public string bustPortrait { get; set; }
    public string fullPortrait { get; set; }
    public string fullPortraitV2 { get; set; }
    public string killfeedPortrait { get; set; }
    public string background { get; set; }
    public string[] backgroundGradientColors { get; set; }
    public string assetPath { get; set; }
    public bool isFullPortraitRightFacing { get; set; }
    public bool isPlayableCharacter { get; set; }
    public bool isAvailableForTest { get; set; }
    public bool isBaseContent { get; set; }
    public Role role { get; set; }
    //public Recruitmentdata recruitmentData { get; set; }
    /*    public Ability[] abilities { get; set; }*/
    public object voiceLine { get; set; }
}

public class Role
{
    public string uuid { get; set; }
    public string displayName { get; set; }
    public string description { get; set; }
    public string displayIcon { get; set; }
    public string assetPath { get; set; }
}

//public class Recruitmentdata
//{
//    public string counterId { get; set; }
//    public string milestoneId { get; set; }
//    public int milestoneThreshold { get; set; }
//    public bool useLevelVpCostOverride { get; set; }
//    public int levelVpCostOverride { get; set; }
//    public DateTime startDate { get; set; }
//    public DateTime endDate { get; set; }
//}

//public class Ability
//{
//    public string slot { get; set; }
//    public string displayName { get; set; }
//    public string description { get; set; }
//    public string displayIcon { get; set; }
//}
