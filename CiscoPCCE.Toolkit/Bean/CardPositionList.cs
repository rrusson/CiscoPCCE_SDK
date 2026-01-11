using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("layout")
    [XmlRoot("layout")]
    public class CardPositionList : BaseApiBean
    {
        [XmlArray("cards")]
        [XmlArrayItem("card")]
        public List<CardPosition>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("layout")
        [XmlRoot("results")]
        public class CardPositionListList : BaseApiListBean<CardPositionList>
        {
            [XmlArray("layouts")]
            [XmlArrayItem("layout")]
            public new List<CardPositionList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<CardPositionList>? GetItems() => Items;

            public override void SetItems(List<CardPositionList>? value) => Items = value;
        }
    }
}