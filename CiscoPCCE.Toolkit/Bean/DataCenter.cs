using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("datacenter")
[XmlRoot("datacenter")]
public class DataCenter : BaseApiBean {
  private AgentPG agentPG;
  private string? baseUrlfromRefUrl;
  private bool? cMPublisherAssociationRequired;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private bool? eceConfigured;
  private string? idFromRefUrl;
  private MultiChannelPG multiChannelPG;
  private string? name;
  private string? refURL;
  private string? sideAPGAddress;
  private string? sideBPGAddress;
  private VruPG vruPG;

  public AgentPG AgentPG
  {
      get => agentPG;
      set => agentPG = value;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public bool? CMPublisherAssociationRequired
  {
      get => cMPublisherAssociationRequired;
      set => cMPublisherAssociationRequired = value;
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

  public bool? EceConfigured
  {
      get => eceConfigured;
      set => eceConfigured = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public MultiChannelPG MultiChannelPG
  {
      get => multiChannelPG;
      set => multiChannelPG = value;
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

  public string? SideAPGAddress
  {
      get => sideAPGAddress;
      set => sideAPGAddress = value;
  }

  public string? SideBPGAddress
  {
      get => sideBPGAddress;
      set => sideBPGAddress = value;
  }

  public VruPG VruPG
  {
      get => vruPG;
      set => vruPG = value;
  }

  // Path("datacenter")
  [XmlRoot("results")]
  public class DataCenterList : BaseApiListBean<DataCenter> {    public override List<DataCenter>? GetItems() => items;

    public override void SetItems(List<DataCenter>? value) => items = value;

  }
}

}