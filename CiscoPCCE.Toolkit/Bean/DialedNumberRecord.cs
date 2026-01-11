using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("dialednumber")
    [XmlRoot("dialedNumberRecord")]
    public class DialedNumberRecord : BaseApiBean
    {
        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        // Path("dialednumber")
        [XmlRoot("results")]
        public class DialedNumberRecordList : BaseApiListBean<DialedNumberRecord>
        {
            [XmlArray("dialedNumberRecords")]
            [XmlArrayItem("dialedNumberRecord")]
            public new List<DialedNumberRecord>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<DialedNumberRecord>? GetItems() => Items;

            public override void SetItems(List<DialedNumberRecord>? value) => Items = value;
        }
    }
}