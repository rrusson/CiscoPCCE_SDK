using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("##default")]
public class StreamingConnectionParams : BaseApiBean {
                      
  public string? LdPassword { get; set; }

  public string? LdSchemaUrl { get; set; }

  public string? LdServiceIP { get; set; }

  public int? LdServicePort { get; set; }

  public string? LdTokenUrl { get; set; }

  public string? LdUserId { get; set; }

  public int? MaxPoolSize { get; set; }

  public int? MinPoolSize { get; set; }

  public string? Password { get; set; }

  public string? UserId { get; set; }

  public int? WebSocketPort { get; set; }

}

}