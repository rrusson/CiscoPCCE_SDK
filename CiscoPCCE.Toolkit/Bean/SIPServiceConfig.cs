using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("sip")]
public class SIPServiceConfig : BaseApiBean {
                              
  public int? CommaDuration { get; set; }

  public bool? EnableOutboundProxy { get; set; }

  public int? IncomingPort { get; set; }

  public int? IncomingSecurePort { get; set; }

  public string? OutboundProxyHost { get; set; }

  public int? OutboundProxyPort { get; set; }

  public string? OutgoingTransport { get; set; }

  public string? SecureCiphers { get; set; }

  public int? SigDigits { get; set; }

  [XmlElement("sipHeaders")]
  [XmlElement("sipHeader")]
  public List<SipHeader>? SipHeaders { get; set; }

  public string? SupportedTLSVersion { get; set; }

  public int? ToneDuration { get; set; }

  public bool? UseErrorRefer { get; set; }

  public bool? UseLocalSrv { get; set; }

  public bool? UseSrv { get; set; }

}

}