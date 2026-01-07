using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("networkvruscript")
[XmlRoot("networkVruScript")]
public class NetworkVruScript : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? configParam;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? interruptible;
  private string? name;
  private string? refURL;
  private int? routingType;
  private int? timeout;
  private string? vruScriptName;

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

  public string? ConfigParam
  {
      get => configParam;
      set => configParam = value;
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

  public bool? Interruptible
  {
      get => interruptible;
      set => interruptible = value;
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

  public int? RoutingType
  {
      get => routingType;
      set => routingType = value;
  }

  public int? Timeout
  {
      get => timeout;
      set => timeout = value;
  }

  public string? VruScriptName
  {
      get => vruScriptName;
      set => vruScriptName = value;
  }

  // Path("networkvruscript")
  [XmlRoot("results")]
  public class NetworkVruScriptList : BaseApiListBean<NetworkVruScript> {    public override List<NetworkVruScript>? GetItems() => items;

    public override void SetItems(List<NetworkVruScript>? value) => items = value;

  }
}

}