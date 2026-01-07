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

  public ReferenceBean DataCenter
  {
      get => dataCenter;
      set => dataCenter = value;
  }

  public string? Port
  {
      get => port;
      set => port = value;
  }

  public string? Priority
  {
      get => priority;
      set => priority = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public string? SecurePort
  {
      get => securePort;
      set => securePort = value;
  }

  public string? Weight
  {
      get => weight;
      set => weight = value;
  }

  // Path("sipservergroup")
  [XmlRoot("results")]
  public class SipServerElementList : BaseApiListBean<SipServerElement> {    public override List<SipServerElement>? GetItems() => items;

    public override void SetItems(List<SipServerElement>? value) => items = value;

  }
}

}