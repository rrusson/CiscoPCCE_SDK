using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("layoutprofile")]
public class LayoutProfile : BaseApiBean {
  private string? layoutXml;
  private string? layoutXmlName;

  public string? LayoutXml
  {
      get => layoutXml;
      set => layoutXml = value;
  }


  public void setLayoutXml(String layoutXml) {
     this.layoutXml = layoutXml;
  }

  public string? LayoutXmlName
  {
      get => layoutXmlName;
      set => layoutXmlName = value;
  }


  public void setLayoutXmlName(String layoutXmlName) {
     this.layoutXmlName = layoutXmlName;
  }


}

}