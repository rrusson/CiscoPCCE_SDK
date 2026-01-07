using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("awstatus")
    [XmlRoot("awStatus")]
    public class AwStatus : BaseApiBean
    {
        [XmlElement("##default")]
        public double? LastRetrievalKey { get; set; }

        // Path("awstatus")
        [XmlRoot("results")]
        public class AwStatusList : BaseApiListBean<AwStatus>
        {
            public override List<AwStatus>? GetItems() => Items;

            public override void SetItems(List<AwStatus>? value) => Items = value;
        }
    }
}