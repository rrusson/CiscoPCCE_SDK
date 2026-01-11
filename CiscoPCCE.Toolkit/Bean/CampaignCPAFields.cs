using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class CampaignCPAFields : BaseApiBean
    {
        [XmlElement("analysisPeriod")]
        public int? AnalysisPeriod { get; set; }

        [XmlElement("record")]
        public bool? EnableRecordWaveFile { get; set; }

        [XmlElement("enabled")]
        public bool? Enabled { get; set; }

        [XmlElement("maxTermToneAnalysis")]
        public int? MaxTermToneAnalysis { get; set; }

        [XmlElement("maxTimeAnalysis")]
        public int? MaxTimeAnalysis { get; set; }

        [XmlElement("minSilencePeriod")]
        public int? MinSilencePeriod { get; set; }

        [XmlElement("minimumValidSpeech")]
        public int? MinimumValidSpeech { get; set; }
    }
}