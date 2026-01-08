using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharequeue")
    [XmlRoot("targetQueue")]
    public class TargetQueue : BaseApiBean
    {
        [XmlElement("id")]
        public int? Id { get; set; }

        // Path("contactsharequeue")
        [XmlRoot("results")]
        public class TargetQueueList : BaseApiListBean<TargetQueue>
        {
            public override List<TargetQueue>? GetItems() => Items;

            public override void SetItems(List<TargetQueue>? value) => Items = value;
        }
    }
}