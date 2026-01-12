using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("campaign")
    [XmlRoot("results")]
    public class CampaignStatusList : BaseApiList<CampaignStatus>
    {
        [XmlArray("runtimeStatuss")]
        [XmlArrayItem("runtimeStatus")]
        public new List<CampaignStatus>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}