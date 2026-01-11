using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesstimezone")
    [XmlRoot("businesstimezone")]
    public class BusinessTimeZone : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("businesstimezone")]
        public string? BusinessTimeZoneName { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("businesstimezone")
        [XmlRoot("results")]
        public class BusinessTimeZoneList : BaseApiListBean<BusinessTimeZone>
        {
            [XmlArray("businesstimezones")]
            [XmlArrayItem("businesstimezone")]
            public new List<BusinessTimeZone>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<BusinessTimeZone>? GetItems() => Items;

            public override void SetItems(List<BusinessTimeZone>? value) => Items = value;
        }
    }
}