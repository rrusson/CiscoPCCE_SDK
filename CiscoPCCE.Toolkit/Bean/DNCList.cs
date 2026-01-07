using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("dnc")
    [XmlRoot("results")]
    public class DNCList : BaseApiBean
    {
        [XmlElement("dncs")]
        [XmlElement("dnc")]
        public List<ImportRule>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("dnc")
        [XmlRoot("results")]
        public class DNCListList : BaseApiListBean<DNCList>
        {
            public override List<DNCList>? GetItems() => Items;

            public override void SetItems(List<DNCList>? value) => Items = value;
        }
    }
}