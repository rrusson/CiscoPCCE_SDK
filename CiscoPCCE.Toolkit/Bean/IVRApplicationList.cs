using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("transferablefiles")
    [XmlRoot("results")]
    public class IVRApplicationList : BaseApiList<IVRApplication>
    {
        [XmlArray("IVRApplications")]
        [XmlArrayItem("IVRApplication")]
        public new List<IVRApplication>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}