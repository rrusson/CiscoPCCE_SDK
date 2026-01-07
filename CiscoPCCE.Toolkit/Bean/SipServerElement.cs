using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("sipservergroup")
[XmlRoot("element")]
public class SipServerElement : BaseApiBean {
  private string? address;
  private ReferenceBean dataCenter;
  private string? port;
  private string? priority;
  private string? refURL;
  private string? securePort;
  private string? weight;

  public string? Address
  {
      get => address;
      set => address = value;
  }


  public void setAddress(String address) {
     this.address = address;
  }

  public ReferenceBean DataCenter
  {
      get => dataCenter;
      set => dataCenter = value;
  }


  public void setDataCenter(ReferenceBean dataCenter) {
     this.dataCenter = dataCenter;
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

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
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


  // Path("sipservergroup")
  [XmlRoot("results")]
  public class SipServerElementList : BaseApiListBean<SipServerElement> {
    [XmlElement("elements")]
    [XmlElement("element")]
   
    public override List<SipServerElement>? GetItems() => items;

    public override void SetItems(List<SipServerElement>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SipServerElement>? items)
    {
        this.items = items;
    }
  }
}

}