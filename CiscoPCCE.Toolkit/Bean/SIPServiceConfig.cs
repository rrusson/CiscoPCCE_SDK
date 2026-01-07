using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("sip")]
public class SIPServiceConfig : BaseApiBean {
  private int? commaDuration;
  private bool? enableOutboundProxy;
  private int? incomingPort;
  private int? incomingSecurePort;
  private string? outboundProxyHost;
  private int? outboundProxyPort;
  private string? outgoingTransport;
  private string? secureCiphers;
  private int? sigDigits;
  private List<SipHeader>? sipHeaders;
  private string? supportedTLSVersion;
  private int? toneDuration;
  private bool? useErrorRefer;
  private bool? useLocalSrv;
  private bool? useSrv;

  public int? CommaDuration
  {
      get => commaDuration;
      set => commaDuration = value;
  }


  public void setCommaDuration(int? commaDuration) {
     this.commaDuration = commaDuration;
  }

  public bool? EnableOutboundProxy
  {
      get => enableOutboundProxy;
      set => enableOutboundProxy = value;
  }


  public void setEnableOutboundProxy(Boolean enableOutboundProxy) {
     this.enableOutboundProxy = enableOutboundProxy;
  }

  public int? IncomingPort
  {
      get => incomingPort;
      set => incomingPort = value;
  }


  public void setIncomingPort(int? incomingPort) {
     this.incomingPort = incomingPort;
  }

  public int? IncomingSecurePort
  {
      get => incomingSecurePort;
      set => incomingSecurePort = value;
  }


  public void setIncomingSecurePort(int? incomingSecurePort) {
     this.incomingSecurePort = incomingSecurePort;
  }

  public string? OutboundProxyHost
  {
      get => outboundProxyHost;
      set => outboundProxyHost = value;
  }


  public void setOutboundProxyHost(String outboundProxyHost) {
     this.outboundProxyHost = outboundProxyHost;
  }

  public int? OutboundProxyPort
  {
      get => outboundProxyPort;
      set => outboundProxyPort = value;
  }


  public void setOutboundProxyPort(int? outboundProxyPort) {
     this.outboundProxyPort = outboundProxyPort;
  }

  public string? OutgoingTransport
  {
      get => outgoingTransport;
      set => outgoingTransport = value;
  }


  public void setOutgoingTransport(String outgoingTransport) {
     this.outgoingTransport = outgoingTransport;
  }

  public string? SecureCiphers
  {
      get => secureCiphers;
      set => secureCiphers = value;
  }


  public void setSecureCiphers(String secureCiphers) {
     this.secureCiphers = secureCiphers;
  }

  public int? SigDigits
  {
      get => sigDigits;
      set => sigDigits = value;
  }


  public void setSigDigits(int? sigDigits) {
     this.sigDigits = sigDigits;
  }

  [XmlElement("sipHeaders")]
  [XmlElement("sipHeader")]
  public List<SipHeader>? SipHeaders
  {
      get => sipHeaders;
      set => sipHeaders = value;
  }


  public void setSipHeaders(List<SipHeader> sipHeaders) {
     this.sipHeaders = sipHeaders;
  }

  public string? SupportedTLSVersion
  {
      get => supportedTLSVersion;
      set => supportedTLSVersion = value;
  }


  public void setSupportedTLSVersion(String supportedTLSVersion) {
     this.supportedTLSVersion = supportedTLSVersion;
  }

  public int? ToneDuration
  {
      get => toneDuration;
      set => toneDuration = value;
  }


  public void setToneDuration(int? toneDuration) {
     this.toneDuration = toneDuration;
  }

  public bool? UseErrorRefer
  {
      get => useErrorRefer;
      set => useErrorRefer = value;
  }


  public void setUseErrorRefer(Boolean useErrorRefer) {
     this.useErrorRefer = useErrorRefer;
  }

  public bool? UseLocalSrv
  {
      get => useLocalSrv;
      set => useLocalSrv = value;
  }


  public void setUseLocalSrv(Boolean useLocalSrv) {
     this.useLocalSrv = useLocalSrv;
  }

  public bool? UseSrv
  {
      get => useSrv;
      set => useSrv = value;
  }


  public void setUseSrv(Boolean useSrv) {
     this.useSrv = useSrv;
  }


}

}