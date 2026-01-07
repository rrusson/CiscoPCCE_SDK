using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class MultiChannelPG : BaseApiBean {
  private bool? configured;

  [XmlElement("configured")]
  public bool? Configured
  {
      get => configured;
      set => configured = value;
  }


  public void setConfigured(Boolean configured) {
     this.configured = configured;
  }


}

}