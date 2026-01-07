using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("sipservergroup")
[XmlRoot("sipServerGroup")]
public class SipServerGroup : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean datacenter;
  private bool? defaultGroup;
  private ReferenceBean department;
  private string? description;
  private List<SipServerElement>? elements;
  private string? idFromRefUrl;
  private string? name;
  private int? noOfElements;
  private string? refURL;
  private SipServerType type;

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

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }

  public bool? DefaultGroup
  {
      get => defaultGroup;
      set => defaultGroup = value;
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

  [XmlElement("elements")]
  [XmlElement("element")]
  public List<SipServerElement>? Elements
  {
      get => elements;
      set => elements = value;
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

  public int? NoOfElements
  {
      get => noOfElements;
      set => noOfElements = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public SipServerType Type
  {
      get => type;
      set => type = value;
  }

  // Path("sipservergroup")
  [XmlRoot("results")]
  public class SipServerGroupList : BaseApiListBean<SipServerGroup> {    public override List<SipServerGroup>? GetItems() => items;

    public override void SetItems(List<SipServerGroup>? value) => items = value;

  }
}

}