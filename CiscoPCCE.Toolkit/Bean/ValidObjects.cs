using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("validobjects")
    [XmlRoot("validObjects")]
    public class ValidObjects : BaseApiBean
    {
        [XmlElement("access")]
        public Access Access { get; set; }

        public List<int?>? Ids { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }

        // Path("validobjects")
        [XmlRoot("results")]
        public class ValidObjectsList : BaseApiListBean<ValidObjects>
        {
            [XmlArray("validObjectss")]
            [XmlArrayItem("validObjects")]
            public new List<ValidObjects>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ValidObjects>? GetItems() => Items;

            public override void SetItems(List<ValidObjects>? value) => Items = value;
        }
    }
}