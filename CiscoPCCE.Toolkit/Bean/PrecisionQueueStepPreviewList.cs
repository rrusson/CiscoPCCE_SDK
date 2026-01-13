using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/pqsteppreview")
    [XmlRoot("results")]
    public class PrecisionQueueStepPreviewList : BaseApiList<PrecisionQueueStepPreview>
    {
        [XmlArray("pqStepPreviews")]
        [XmlArrayItem("pqStepPreview")]
        public new List<PrecisionQueueStepPreview>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}