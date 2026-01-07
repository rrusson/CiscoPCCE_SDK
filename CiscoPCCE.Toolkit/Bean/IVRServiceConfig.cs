using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("ivr")]
public class IVRServiceConfig : BaseApiBean {
        
  public int? CallTimeout { get; set; }

  public bool? UseBackupMediaServers { get; set; }

  public bool? UseMediaServerHostNames { get; set; }

  public bool? UseSecurityForMediaFetches { get; set; }

}

}