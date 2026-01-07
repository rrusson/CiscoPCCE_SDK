using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("##default")]
public class DBConnectionParams : BaseApiBean {
                  
  public string? Database { get; set; }

  public string? DbEncoding { get; set; }

  public string? DbInstance { get; set; }

  public string? Host { get; set; }

  public int? MaxPoolSize { get; set; }

  public int? MinPoolSize { get; set; }

  public string? Password { get; set; }

  public int? Port { get; set; }

  public string? UserId { get; set; }

}

}