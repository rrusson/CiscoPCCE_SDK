using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("question")]
    public class SurveyQuestion : BaseApiBean
    {
        public string? DispatchId { get; set; }

        public string? QuestionnaireName { get; set; }
    }
}