using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("question")]
    public class SurveyQuestion : BaseApiBean
    {
        [XmlElement("dispatchId")]
        public string? DispatchId { get; set; }

        [XmlElement("questionnaireName")]
        public string? QuestionnaireName { get; set; }
    }
}