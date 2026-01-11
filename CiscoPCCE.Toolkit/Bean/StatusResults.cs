using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("status")
    [XmlRoot("results")]
    public class StatusResults : BaseApiBean
    {
        [XmlArray("statuses")]
        [XmlArrayItem("status")]
        public List<Status>? Statuses { get; set; }

        // Path("status")
        [XmlRoot("results")]
        public class StatusResultsList : BaseApiListBean<StatusResults>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<StatusResults>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<StatusResults>? GetItems() => Items;

            public override void SetItems(List<StatusResults>? value) => Items = value;
        }
    }
}