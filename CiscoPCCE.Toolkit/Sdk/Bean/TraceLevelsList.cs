using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("tracelevel")
    [XmlRoot("results")]
    public class TraceLevelsList : BaseApiList<TraceLevels>
    {
        [XmlArray("traceLevelss")]
        [XmlArrayItem("traceLevels")]
        public new List<TraceLevels>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}