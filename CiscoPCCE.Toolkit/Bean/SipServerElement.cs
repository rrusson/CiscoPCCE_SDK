using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroup")
    [XmlRoot("element")]
    public class SipServerElement : BaseApiBean
    {
        public string? Address { get; set; }

        public required ReferenceBean DataCenter { get; set; }

        public string? Port { get; set; }

        public string? Priority { get; set; }

        public new string? RefURL { get; set; }

        public string? SecurePort { get; set; }

        public string? Weight { get; set; }

        // Path("sipservergroup")
        [XmlRoot("results")]
        public class SipServerElementList : BaseApiListBean<SipServerElement>
        {
            public override List<SipServerElement>? GetItems() => Items;

            public override void SetItems(List<SipServerElement>? value) => Items = value;
        }
    }
}