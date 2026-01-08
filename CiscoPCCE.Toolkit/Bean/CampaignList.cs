using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("campaign")
    [XmlRoot("results")]
    public class CampaignList : BaseApiBean
    {
        [XmlArray("campaigns")]
        [XmlArrayItem("campaign")]
        public List<Campaign>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("campaign")
        [XmlRoot("results")]
        public class CampaignListList : BaseApiListBean<CampaignList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<CampaignList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<CampaignList>? GetItems() => Items;

            public override void SetItems(List<CampaignList>? value) => Items = value;
        }
    }
}