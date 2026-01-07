using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("validobjects")
    [XmlRoot("validObjects")]
    public class ValidObjects : BaseApiBean
    {
        public Access Access { get; set; }

        public List<int?>? Ids { get; set; }

        public string? Type { get; set; }

        // Path("validobjects")
        [XmlRoot("results")]
        public class ValidObjectsList : BaseApiListBean<ValidObjects>
        {
            public override List<ValidObjects>? GetItems() => Items;

            public override void SetItems(List<ValidObjects>? value) => Items = value;
        }
    }
}