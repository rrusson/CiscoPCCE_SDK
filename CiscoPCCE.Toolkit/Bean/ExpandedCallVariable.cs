using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("expandedcallvariable")
[XmlRoot("expandedCallVariable")]
public class ExpandedCallVariable : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? bytesRequired;
  private int? bytesRequiredInCtiServer;
  private int? changeStamp;
  private bool? ciscoProvided;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private bool? eccArray;
  private bool? enabled;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private int? maximumArraySize;
  private int? maximumLength;
  private string? name;
  private bool? persistent;
  private string? refURL;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public int? BytesRequired
  {
      get => bytesRequired;
      set => bytesRequired = value;
  }

  public int? BytesRequiredInCtiServer
  {
      get => bytesRequiredInCtiServer;
      set => bytesRequiredInCtiServer = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public bool? CiscoProvided
  {
      get => ciscoProvided;
      set => ciscoProvided = value;
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

  public bool? EccArray
  {
      get => eccArray;
      set => eccArray = value;
  }

  public bool? Enabled
  {
      get => enabled;
      set => enabled = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public int? MaximumArraySize
  {
      get => maximumArraySize;
      set => maximumArraySize = value;
  }

  public int? MaximumLength
  {
      get => maximumLength;
      set => maximumLength = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public bool? Persistent
  {
      get => persistent;
      set => persistent = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("expandedcallvariable")
  [XmlRoot("results")]
  public class ExpandedCallVariableList : BaseApiListBean<ExpandedCallVariable> {    public override List<ExpandedCallVariable>? GetItems() => items;

    public override void SetItems(List<ExpandedCallVariable>? value) => items = value;

  }
}

}