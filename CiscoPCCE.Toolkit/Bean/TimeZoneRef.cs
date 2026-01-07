using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class TimeZoneRef : BaseApiBean {
  private string? displayName;
  private string? refURL;

  [XmlElement("displayName")]
  public string? DisplayName
  {
      get => displayName;
      set => displayName = value;
  }


  public void setDisplayName(String displayName) {
     this.displayName = displayName;
  }

  [XmlElement("refURL")]
  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


}

}