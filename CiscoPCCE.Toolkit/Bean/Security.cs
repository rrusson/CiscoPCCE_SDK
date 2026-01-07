using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class Security : BaseApiBean {
  private bool? allowMixedMode;
  private Ciphers ciphers;
  private bool? sipTLSEnabled;
  private bool? srtp;
  private string? tlsVersion;

  public bool? AllowMixedMode
  {
      get => allowMixedMode;
      set => allowMixedMode = value;
  }


  public void setAllowMixedMode(Boolean allowMixedMode) {
     this.allowMixedMode = allowMixedMode;
  }

  public Ciphers Ciphers
  {
      get => ciphers;
      set => ciphers = value;
  }


  public void setCiphers(Ciphers ciphers) {
     this.ciphers = ciphers;
  }

  public bool? SipTLSEnabled
  {
      get => sipTLSEnabled;
      set => sipTLSEnabled = value;
  }


  public void setSipTLSEnabled(Boolean sipTLSEnabled) {
     this.sipTLSEnabled = sipTLSEnabled;
  }

  public bool? Srtp
  {
      get => srtp;
      set => srtp = value;
  }


  public void setSrtp(Boolean srtp) {
     this.srtp = srtp;
  }

  public string? TlsVersion
  {
      get => tlsVersion;
      set => tlsVersion = value;
  }


  public void setTlsVersion(String tlsVersion) {
     this.tlsVersion = tlsVersion;
  }


}

}