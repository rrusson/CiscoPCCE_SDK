using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("targetInstances")]
            [XmlArrayItem("targetInstance")]
            public new List<TargetInstanceRef>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<TargetInstanceRef>? GetItems() => Items;

            public override void SetItems(List<TargetInstanceRef>? value) => Items = value;
        }
    }
}