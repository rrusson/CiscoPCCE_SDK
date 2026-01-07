using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("enterpriseroute")
[XmlRoot("enterpriseRoute")]
public class EnterpriseRoute : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private int entityID;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
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

  public int EntityID
  {
      get => entityID;
      set => entityID = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("enterpriseroute")
  [XmlRoot("results")]
  public class EnterpriseRouteList : BaseApiListBean<EnterpriseRoute> {    public override List<EnterpriseRoute>? GetItems() => items;

    public override void SetItems(List<EnterpriseRoute>? value) => items = value;

  }
}

}