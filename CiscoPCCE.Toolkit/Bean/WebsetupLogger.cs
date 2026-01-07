using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("logger")]
public class WebsetupLogger : BaseApiBean {
              
  public string? LoggerSideAPrivateAddress { get; set; }

  public string? LoggerSideBPrivateAddress { get; set; }

  public string? RouterSideAPrivateAddress { get; set; }

  public string? RouterSideBPrivateAddress { get; set; }

  public string? ServiceAccountPassword { get; set; }

  public string? ServiceAccountUserName { get; set; }

  public string? Side { get; set; }

}

}