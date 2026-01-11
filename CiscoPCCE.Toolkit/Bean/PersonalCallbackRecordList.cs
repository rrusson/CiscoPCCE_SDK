using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("personalcallback")
    [XmlRoot("results")]
    public class PersonalCallbackRecordList : BaseApiBean
    {
        [XmlArray("personalCallbacks")]
        [XmlArrayItem("personalCallback")]
        public List<PersonalCallbackRecord>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("personalcallback")
        [XmlRoot("results")]
        public class PersonalCallbackRecordListList : BaseApiListBean<PersonalCallbackRecordList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<PersonalCallbackRecordList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<PersonalCallbackRecordList>? GetItems() => Items;

            public override void SetItems(List<PersonalCallbackRecordList>? value) => Items = value;
        }
    }
}