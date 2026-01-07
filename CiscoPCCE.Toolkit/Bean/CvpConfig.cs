using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("CvpConfig")]
public class CvpConfig : BaseApiBean {
        
  public string? BackupServerIPAddress { get; set; }

  public string? DeviceId { get; set; }

  public string? HostName { get; set; }

  public string? IpAddress { get; set; }

}

}