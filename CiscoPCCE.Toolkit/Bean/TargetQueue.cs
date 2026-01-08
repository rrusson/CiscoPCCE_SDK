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
            [XmlArray("targetQueues")]
            [XmlArrayItem("targetQueue")]
            public new List<TargetQueue>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<TargetQueue>? GetItems() => Items;

            public override void SetItems(List<TargetQueue>? value) => Items = value;
        }
    }
}