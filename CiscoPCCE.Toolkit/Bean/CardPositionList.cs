using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("layout")]
    public class CardPositionList : BaseApiBean
    {
        [XmlArray("cards")]
        [XmlArrayItem("card")]
        public List<CardPosition>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
        [XmlType("results")]
        public class CardPositionListList : BaseApiList<CardPositionList>
        {
            [XmlArray("layouts")]
            [XmlArrayItem("layout")]
            public new List<CardPositionList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }
        }
    }
}