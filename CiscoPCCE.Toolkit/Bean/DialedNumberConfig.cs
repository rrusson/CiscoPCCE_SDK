using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("dialedNumberConfig")]
public class DialedNumberConfig : BaseApiBean {
      
  public string? DialedNumber { get; set; }

  public string? PostCallSurveyNumber { get; set; }

  public string? Ringtone { get; set; }

}

}