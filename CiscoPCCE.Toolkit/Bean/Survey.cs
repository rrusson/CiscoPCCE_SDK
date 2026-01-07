using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("survey")]
    public class Survey : BaseApiBean
    {
        public string? Application { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? EnterpriseName { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        [XmlElement("surveyDetail")]
        public required SurveyQuestion Question { get; set; }

        public new string? RefURL { get; set; }

        public int? SurveyType { get; set; }
    }
}