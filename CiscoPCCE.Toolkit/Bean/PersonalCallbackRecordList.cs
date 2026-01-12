using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("personalcallback")
    [XmlRoot("results")]
    public class PersonalCallbackRecordList : BaseApiList<PersonalCallbackRecord>
    {
        [XmlArray("personalCallbacks")]
        [XmlArrayItem("personalCallback")]
        public new List<PersonalCallbackRecord>? Items
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