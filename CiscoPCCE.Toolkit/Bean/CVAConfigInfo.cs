using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("speechConfig")]
    public class CVAConfigInfo : BaseApiBean
    {
        [XmlElement("version")]
        public string? Version { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class CVAConfigInfoList : BaseApiListBean<CVAConfigInfo>
        {
            [XmlArray("speechConfigs")]
            [XmlArrayItem("speechConfig")]
            public new List<CVAConfigInfo>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<CVAConfigInfo>? GetItems() => Items;

            public override void SetItems(List<CVAConfigInfo>? value) => Items = value;
        }
    }
}