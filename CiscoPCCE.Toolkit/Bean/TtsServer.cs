using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("ttsServer")]
public class TtsServer : BaseApiBean {
    
  public int? Port { get; set; }

  public string? TtsServerName { get; set; }

}

}