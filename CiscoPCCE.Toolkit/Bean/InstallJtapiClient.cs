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

  public string? CallManagerPublisherVersion
  {
      get => callManagerPublisherVersion;
      set => callManagerPublisherVersion = value;
  }

  // Path("installjtapiclient")
  [XmlRoot("results")]
  public class InstallJtapiClientList : BaseApiListBean<InstallJtapiClient> {    public override List<InstallJtapiClient>? GetItems() => items;

    public override void SetItems(List<InstallJtapiClient>? value) => items = value;

  }
}

}