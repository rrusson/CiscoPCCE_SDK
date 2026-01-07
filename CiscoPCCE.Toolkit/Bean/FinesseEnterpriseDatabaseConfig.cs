using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("EnterpriseDatabaseConfig")]
public class FinesseEnterpriseDatabaseConfig : BaseApiBean {
              
  public string? BackupHost { get; set; }

  public string? DatabaseName { get; set; }

  public string? Domain { get; set; }

  public string? Host { get; set; }

  public string? Password { get; set; }

  public int Port { get; set; }

  [XmlElement("username")]
  public string? UserName { get; set; }

}

}