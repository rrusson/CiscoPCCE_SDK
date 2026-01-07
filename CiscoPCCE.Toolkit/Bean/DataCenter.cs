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


  public void setAgentPG(AgentPG agentPG) {
     this.agentPG = agentPG;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public bool? CMPublisherAssociationRequired
  {
      get => cMPublisherAssociationRequired;
      set => cMPublisherAssociationRequired = value;
  }


  public void setCMPublisherAssociationRequired(bool? cMPublisherAssociationRequired) {
     this.cMPublisherAssociationRequired = cMPublisherAssociationRequired;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public bool? EceConfigured
  {
      get => eceConfigured;
      set => eceConfigured = value;
  }


  public void setEceConfigured(Boolean eceConfigured) {
     this.eceConfigured = eceConfigured;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public MultiChannelPG MultiChannelPG
  {
      get => multiChannelPG;
      set => multiChannelPG = value;
  }


  public void setMultiChannelPG(MultiChannelPG multiChannelPG) {
     this.multiChannelPG = multiChannelPG;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? SideAPGAddress
  {
      get => sideAPGAddress;
      set => sideAPGAddress = value;
  }


  public void setSideAPGAddress(String sideAPGAddress) {
     this.sideAPGAddress = sideAPGAddress;
  }

  public string? SideBPGAddress
  {
      get => sideBPGAddress;
      set => sideBPGAddress = value;
  }


  public void setSideBPGAddress(String sideBPGAddress) {
     this.sideBPGAddress = sideBPGAddress;
  }

  public VruPG VruPG
  {
      get => vruPG;
      set => vruPG = value;
  }


  public void setVruPG(VruPG vruPG) {
     this.vruPG = vruPG;
  }


  // Path("datacenter")
  [XmlRoot("results")]
  public class DataCenterList : BaseApiListBean<DataCenter> {
    [XmlElement("datacenters")]
    [XmlElement("datacenter")]
   
    public override List<DataCenter>? GetItems() => items;

    public override void SetItems(List<DataCenter>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DataCenter>? items)
    {
        this.items = items;
    }
  }
}

}