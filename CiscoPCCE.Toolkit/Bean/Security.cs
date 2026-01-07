using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class Security : BaseApiBean {
          
  public bool? AllowMixedMode { get; set; }

  public Ciphers Ciphers { get; set; }

  public bool? SipTLSEnabled { get; set; }

  public bool? Srtp { get; set; }

  public string? TlsVersion { get; set; }

}

}