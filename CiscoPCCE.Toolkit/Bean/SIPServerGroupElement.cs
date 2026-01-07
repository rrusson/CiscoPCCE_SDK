using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("sipServerGroupElements")]
public class SIPServerGroupElement : BaseApiBean {
  private string? elementName;
  private string? port;
  private string? priority;
  private string? securePort;
  private string? weight;

  public string? ElementName
  {
      get => elementName;
      set => elementName = value;
  }


  public void setElementName(String elementName) {
     this.elementName = elementName;
  }

  public string? Port
  {
      get => port;
      set => port = value;
  }


  public void setPort(String port) {
     this.port = port;
  }

  public string? Priority
  {
      get => priority;
      set => priority = value;
  }


  public void setPriority(String priority) {
     this.priority = priority;
  }

  public string? SecurePort
  {
      get => securePort;
      set => securePort = value;
  }


  public void setSecurePort(String securePort) {
     this.securePort = securePort;
  }

  public string? Weight
  {
      get => weight;
      set => weight = value;
  }


  public void setWeight(String weight) {
     this.weight = weight;
  }


}

}