using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("tracelevel")
    [XmlRoot("results")]
    public class TraceLevelsList : BaseApiBean
    {
        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        [XmlElement("traceLevels")]
        public required TraceLevels TraceLevels { get; set; }

        // Path("tracelevel")
        [XmlRoot("results")]
        public class TraceLevelsListList : BaseApiListBean<TraceLevelsList>
        {
            public override List<TraceLevelsList>? GetItems() => Items;

            public override void SetItems(List<TraceLevelsList>? value) => Items = value;
        }
    }
}