using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharequeue")
    [XmlRoot("targetInstance")]
    public class TargetInstanceRef : BaseApiBean
    {
        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        // Path("contactsharequeue")
        [XmlRoot("results")]
        public class TargetInstanceRefList : BaseApiListBean<TargetInstanceRef>
        {
            public override List<TargetInstanceRef>? GetItems() => Items;

            public override void SetItems(List<TargetInstanceRef>? value) => Items = value;
        }
    }
}