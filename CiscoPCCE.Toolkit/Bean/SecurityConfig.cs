using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("security")]
public class SecurityConfig : BaseApiBean {
          
  public bool? AllowMixedMode { get; set; }

  public Ciphers Ciphers { get; set; }

  public bool? SipTLSEnabled { get; set; }

  public bool? SrtpEnabled { get; set; }

  public string? TlsVersion { get; set; }

}

}