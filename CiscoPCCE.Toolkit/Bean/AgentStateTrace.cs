using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("agentstatetrace")
[XmlRoot("agentstatetrace")]
public class AgentStateTrace : BaseApiBean {
  private List<AgentBase>? agentList;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private PermissionInfo permissionInfo;
  private string? refURL;

  [XmlElement("agents")]
  [XmlElement("agent")]
  public List<AgentBase>? AgentList
  {
      get => agentList;
      set => agentList = value;
  }


  public void setAgentList(List<AgentBase> agentList) {
     this.agentList = agentList;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }


  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("agentstatetrace")
  [XmlRoot("results")]
  public class AgentStateTraceList : BaseApiListBean<AgentStateTrace> {
    [XmlElement("agentstatetraces")]
    [XmlElement("agentstatetrace")]
   
    public override List<AgentStateTrace>? GetItems() => items;

    public override void SetItems(List<AgentStateTrace>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AgentStateTrace>? items)
    {
        this.items = items;
    }
  }
}

}