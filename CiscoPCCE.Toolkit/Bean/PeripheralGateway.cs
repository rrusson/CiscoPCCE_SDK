using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("secondaryaddress")
[XmlRoot("peripheralGateway")]
public class PeripheralGateway : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private short? clientType;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private int? logicalControllerId;
  private short? logicalControllerType;
  private bool? markDeletable;
  private string? name;
  private List<PeripheralWithRoutingClient>? peripherals;
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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public int? LogicalControllerId
  {
      get => logicalControllerId;
      set => logicalControllerId = value;
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

  [XmlElement("peripherals")]
  [XmlElement("peripheral")]
  public List<PeripheralWithRoutingClient>? Peripherals
  {
      get => peripherals;
      set => peripherals = value;
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

  // Path("secondaryaddress")
  [XmlRoot("results")]
  public class PeripheralGatewayList : BaseApiListBean<PeripheralGateway> {    public override List<PeripheralGateway>? GetItems() => items;

    public override void SetItems(List<PeripheralGateway>? value) => items = value;

  }
}

}