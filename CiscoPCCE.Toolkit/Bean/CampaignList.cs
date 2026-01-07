using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("campaign")
    [XmlRoot("results")]
    public class CampaignList : BaseApiBean
    {
        [XmlElement("campaigns")]
        [XmlElement("campaign")]
        public List<Campaign>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("campaign")
        [XmlRoot("results")]
        public class CampaignListList : BaseApiListBean<CampaignList>
        {
            public override List<CampaignList>? GetItems() => Items;

            public override void SetItems(List<CampaignList>? value) => Items = value;
        }
    }
}