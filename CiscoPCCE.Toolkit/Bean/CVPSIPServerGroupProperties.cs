using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("sipservergroupproperties")
[XmlRoot("CVP")]
public class CVPSIPServerGroupProperties : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? correlationId;
  private ReferenceBean department;
  private int? id;
  private string? idFromRefUrl;
  private string? refURL;
  private SIPServerGroupProperties sipServerGroupProperties;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public SIPServerGroupProperties SipServerGroupProperties
  {
      get => sipServerGroupProperties;
      set => sipServerGroupProperties = value;
  }

  // Path("sipservergroupproperties")
  [XmlRoot("results")]
  public class CVPSIPServerGroupPropertiesList : BaseApiListBean<CVPSIPServerGroupProperties> {    public override List<CVPSIPServerGroupProperties>? GetItems() => items;

    public override void SetItems(List<CVPSIPServerGroupProperties>? value) => items = value;

  }
}

}