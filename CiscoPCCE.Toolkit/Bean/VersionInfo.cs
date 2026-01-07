using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("version")]
public class VersionInfo : BaseApiBean {
  private UcceVersion ucceVersion;

  [XmlElement("ucceVersion")]
  public UcceVersion UcceVersion
  {
      get => ucceVersion;
      set => ucceVersion = value;
  }


  public void setUcceVersion(UcceVersion ucceVersion) {
     this.ucceVersion = ucceVersion;
  }


}

}