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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("agentstatetrace")
  [XmlRoot("results")]
  public class AgentStateTraceList : BaseApiListBean<AgentStateTrace> {    public override List<AgentStateTrace>? GetItems() => items;

    public override void SetItems(List<AgentStateTrace>? value) => items = value;

  }
}

}