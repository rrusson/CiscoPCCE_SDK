using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("installjtapiclient")
[XmlRoot("installJtapiClient")]
public class InstallJtapiClient : BaseApiBean {
  private string? callManagerPublisherAddress;
  private string? callManagerPublisherVersion;

  public string? CallManagerPublisherAddress
  {
      get => callManagerPublisherAddress;
      set => callManagerPublisherAddress = value;
  }


  public void setCallManagerPublisherAddress(String callManagerPublisherAddress) {
     this.callManagerPublisherAddress = callManagerPublisherAddress;
  }

  public string? CallManagerPublisherVersion
  {
      get => callManagerPublisherVersion;
      set => callManagerPublisherVersion = value;
  }


  public void setCallManagerPublisherVersion(String callManagerPublisherVersion) {
     this.callManagerPublisherVersion = callManagerPublisherVersion;
  }


  // Path("installjtapiclient")
  [XmlRoot("results")]
  public class InstallJtapiClientList : BaseApiListBean<InstallJtapiClient> {
    [XmlElement("installJtapiClients")]
    [XmlElement("installJtapiClient")]
   
    public override List<InstallJtapiClient>? GetItems() => items;

    public override void SetItems(List<InstallJtapiClient>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<InstallJtapiClient>? items)
    {
        this.items = items;
    }
  }
}

}