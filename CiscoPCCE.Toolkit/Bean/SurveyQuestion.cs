using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("question")]
    public class SurveyQuestion : BaseApiBean
    {
        [XmlElement("dispatchId")]
        public string? DispatchId { get; set; }

        [XmlElement("questionnaireName")]
        public string? QuestionnaireName { get; set; }
    }
}