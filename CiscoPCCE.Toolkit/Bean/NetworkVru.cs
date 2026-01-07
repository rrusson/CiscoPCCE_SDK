using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("networkvru")
[XmlRoot("networkVru")]
public class NetworkVru : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;
  private int type;

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

  public string? Description
  {
      get => description;
      set => description = value;
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

  public int Type
  {
      get => type;
      set => type = value;
  }

  // Path("networkvru")
  [XmlRoot("results")]
  public class NetworkVruList : BaseApiListBean<NetworkVru> {    public override List<NetworkVru>? GetItems() => items;

    public override void SetItems(List<NetworkVru>? value) => items = value;

  }
}

}