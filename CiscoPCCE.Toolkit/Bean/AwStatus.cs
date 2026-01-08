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
            [XmlArray("awStatuss")]
            [XmlArrayItem("awStatus")]
            public new List<AwStatus>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<AwStatus>? GetItems() => Items;

            public override void SetItems(List<AwStatus>? value) => Items = value;
        }
    }
}