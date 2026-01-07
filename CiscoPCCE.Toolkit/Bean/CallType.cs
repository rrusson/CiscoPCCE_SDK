using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("calltype")
    [XmlRoot("callType")]
    public class CallType : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public required ReferenceBean BucketInterval { get; set; }

        [XmlElement("id")]
        public int? CallTypeId { get; set; }

        public string? CcaiConfigID { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        [XmlElement("##default")]
        [XmlElement("scriptSchedule")]
        public List<ScriptSchedule>? ScriptSchedules { get; set; }

        public int? ServiceLevelThreshold { get; set; }

        public int? ServiceLevelType { get; set; }

        // Path("calltype")
        [XmlRoot("results")]
        public class CallTypeList : BaseApiListBean<CallType>
        {
            public override List<CallType>? GetItems() => Items;

            public override void SetItems(List<CallType>? value) => Items = value;
        }
    }
}