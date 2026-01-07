using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("security")]
public class SecurityConfig : BaseApiBean {
  private bool? allowMixedMode;
  private Ciphers ciphers;
  private bool? sipTLSEnabled;
  private bool? srtpEnabled;
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

  public bool? SrtpEnabled
  {
      get => srtpEnabled;
      set => srtpEnabled = value;
  }


  public void setSrtpEnabled(Boolean srtpEnabled) {
     this.srtpEnabled = srtpEnabled;
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