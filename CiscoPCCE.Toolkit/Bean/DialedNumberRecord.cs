using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("dialednumber")
    [XmlRoot("dialedNumberRecord")]
    public class DialedNumberRecord : BaseApiBean
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        // Path("dialednumber")
        [XmlRoot("results")]
        public class DialedNumberRecordList : BaseApiListBean<DialedNumberRecord>
        {
            public override List<DialedNumberRecord>? GetItems() => Items;

            public override void SetItems(List<DialedNumberRecord>? value) => Items = value;
        }
    }
}