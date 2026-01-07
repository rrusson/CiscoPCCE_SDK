using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class CampaignCPAFields : BaseApiBean {
              
  public int? AnalysisPeriod { get; set; }

  [XmlElement("record")]
  public bool? EnableRecordWaveFile { get; set; }

  public bool? Enabled { get; set; }

  public int? MaxTermToneAnalysis { get; set; }

  public int? MaxTimeAnalysis { get; set; }

  public int? MinSilencePeriod { get; set; }

  public int? MinimumValidSpeech { get; set; }

}

}