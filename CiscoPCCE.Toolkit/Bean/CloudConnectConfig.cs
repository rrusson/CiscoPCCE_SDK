using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("CloudConnectConfig")]
public class CloudConnectConfig : BaseApiBean {
        
  public string? Password { get; set; }

  public string? PublisherAddress { get; set; }

  public string? SubscriberAddress { get; set; }

  public string? UserName { get; set; }

}

}