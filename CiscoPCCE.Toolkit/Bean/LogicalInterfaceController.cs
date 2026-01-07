using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("globalsetting")
[XmlRoot("pg")]
public class LogicalInterfaceController : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private short? clientType;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private short? logicalControllerType;
  private bool? markDeletable;
  private string? name;
  private string? primaryCtiAddress;
  private string? refURL;
  private string? secondaryCtiAddress;

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

  public short? ClientType
  {
      get => clientType;
      set => clientType = value;
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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public short? LogicalControllerType
  {
      get => logicalControllerType;
      set => logicalControllerType = value;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public string? PrimaryCtiAddress
  {
      get => primaryCtiAddress;
      set => primaryCtiAddress = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public string? SecondaryCtiAddress
  {
      get => secondaryCtiAddress;
      set => secondaryCtiAddress = value;
  }

  // Path("globalsetting")
  [XmlRoot("results")]
  public class LogicalInterfaceControllerList : BaseApiListBean<LogicalInterfaceController> {    public override List<LogicalInterfaceController>? GetItems() => items;

    public override void SetItems(List<LogicalInterfaceController>? value) => items = value;

  }
}

}