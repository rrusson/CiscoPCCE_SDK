using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshourstatusreason")
    [XmlRoot("businessHourStatusReason")]
    public class BusinessHourStatusReason : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("category")]
        public string? Category { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("reasonCode")]
        public int? ReasonCode { get; set; }

        [XmlElement("reasonText")]
        public string? ReasonText { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("businesshourstatusreason")
        [XmlRoot("results")]
        public class BusinessHourStatusReasonList : BaseApiListBean<BusinessHourStatusReason>
        {
            [XmlArray("businessHourStatusReasons")]
            [XmlArrayItem("businessHourStatusReason")]
            public new List<BusinessHourStatusReason>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<BusinessHourStatusReason>? GetItems() => Items;

            public override void SetItems(List<BusinessHourStatusReason>? value) => Items = value;
        }
    }
}