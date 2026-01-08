using System.Xml.Serialization;

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
            public override List<StatusResults>? GetItems() => Items;

            public override void SetItems(List<StatusResults>? value) => Items = value;
        }
    }
}