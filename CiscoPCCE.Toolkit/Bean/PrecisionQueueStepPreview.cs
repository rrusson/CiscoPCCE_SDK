using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/pqsteppreview")
    [XmlRoot("pqStepPreview")]
    public class PrecisionQueueStepPreview : BaseApiBean
    {
        [XmlElement("agentCount")]
        public int? AgentCount { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required Step Step { get; set; }

        // Path("/pqsteppreview")
        [XmlRoot("results")]
        public class PrecisionQueueStepPreviewList : BaseApiListBean<PrecisionQueueStepPreview>
        {
            public override List<PrecisionQueueStepPreview>? GetItems() => Items;

            public override void SetItems(List<PrecisionQueueStepPreview>? value) => Items = value;
        }
    }
}