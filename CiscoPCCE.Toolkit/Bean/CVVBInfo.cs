using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("vvbInfo")]
public class CVVBInfo : BaseApiBean {
  private string? status;
  private string? version;

  [XmlElement("vvbStatus")]
  public string? Status
  {
      get => status;
      set => status = value;
  }


  public void setStatus(String status) {
     this.status = status;
  }

  [XmlElement("vvbVersion")]
  public string? Version
  {
      get => version;
      set => version = value;
  }


  public void setVersion(String version) {
     this.version = version;
  }


}

}