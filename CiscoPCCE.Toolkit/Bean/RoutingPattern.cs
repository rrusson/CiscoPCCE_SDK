using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("routingpattern")
[XmlRoot("routingPattern")]
public class RoutingPattern : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? configParam;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private string? description;
  private string? destination;
  private string? idFromRefUrl;
  private string? pattern;
  private int? patternType;
  private string? refURL;
  private int? rnaTimeout;
  private bool? sendToOriginator;

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

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
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

  public string? Destination
  {
      get => destination;
      set => destination = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? Pattern
  {
      get => pattern;
      set => pattern = value;
  }

  public int? PatternType
  {
      get => patternType;
      set => patternType = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public int? RnaTimeout
  {
      get => rnaTimeout;
      set => rnaTimeout = value;
  }

  public bool? SendToOriginator
  {
      get => sendToOriginator;
      set => sendToOriginator = value;
  }

  // Path("routingpattern")
  [XmlRoot("results")]
  public class RoutingPatternList : BaseApiListBean<RoutingPattern> {    public override List<RoutingPattern>? GetItems() => items;

    public override void SetItems(List<RoutingPattern>? value) => items = value;

  }
}

}