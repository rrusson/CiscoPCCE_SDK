using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<TraceLevelsList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<TraceLevelsList>? GetItems() => Items;

            public override void SetItems(List<TraceLevelsList>? value) => Items = value;
        }
    }
}