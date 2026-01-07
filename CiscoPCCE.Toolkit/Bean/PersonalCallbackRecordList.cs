using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("personalcallback")
    [XmlRoot("results")]
    public class PersonalCallbackRecordList : BaseApiBean
    {
        [XmlElement("personalCallbacks")]
        [XmlElement("personalCallback")]
        public List<PersonalCallbackRecord>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("personalcallback")
        [XmlRoot("results")]
        public class PersonalCallbackRecordListList : BaseApiListBean<PersonalCallbackRecordList>
        {
            public override List<PersonalCallbackRecordList>? GetItems() => Items;

            public override void SetItems(List<PersonalCallbackRecordList>? value) => Items = value;
        }
    }
}