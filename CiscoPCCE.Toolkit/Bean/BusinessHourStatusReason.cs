using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshourstatusreason")
    [XmlRoot("businessHourStatusReason")]
    public class BusinessHourStatusReason : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public string? Category { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public int? ReasonCode { get; set; }

        public string? ReasonText { get; set; }

        public new string? RefURL { get; set; }

        // Path("businesshourstatusreason")
        [XmlRoot("results")]
        public class BusinessHourStatusReasonList : BaseApiListBean<BusinessHourStatusReason>
        {
            public override List<BusinessHourStatusReason>? GetItems() => Items;

            public override void SetItems(List<BusinessHourStatusReason>? value) => Items = value;
        }
    }
}