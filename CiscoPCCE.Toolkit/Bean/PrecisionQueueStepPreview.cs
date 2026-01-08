using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/pqsteppreview")
    [XmlRoot("pqStepPreview")]
    public class PrecisionQueueStepPreview : BaseApiBean
    {
        [XmlElement("agentCount")]
        public int? AgentCount { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("step")]
        public required Step Step { get; set; }

        // Path("/pqsteppreview")
        [XmlRoot("results")]
        public class PrecisionQueueStepPreviewList : BaseApiListBean<PrecisionQueueStepPreview>
        {
            [XmlArray("pqStepPreviews")]
            [XmlArrayItem("pqStepPreview")]
            public new List<PrecisionQueueStepPreview>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<PrecisionQueueStepPreview>? GetItems() => Items;

            public override void SetItems(List<PrecisionQueueStepPreview>? value) => Items = value;
        }
    }
}