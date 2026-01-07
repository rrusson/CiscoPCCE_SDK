using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agentdesksetting")
[XmlRoot("agentDeskSetting")]
public class AgentDeskSetting : BaseApiBean {
  private AgentStateAfterRONAEnum agentStateAfterRONA;
  private bool? autoAnswerEnabled;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private int? emergencyCallMethod;
  private string? idFromRefUrl;
  private bool? idleReasonRequired;
  private int? logoutNonActivityTime;
  private bool? logoutReasonRequired;
  private string? name;
  private int? playZipTone;
  private string? refURL;
  private int? remoteAgentType;
  private int? supervisorAssistCallMethod;
  private int? workModeTimer;
  private int? wrapupDataIncomingMode;
  private int? wrapupDataOutgoingMode;
  private int? acdSharedLineUsage;

  public AgentStateAfterRONAEnum AgentStateAfterRONA
  {
      get => agentStateAfterRONA;
      set => agentStateAfterRONA = value;
  }

  public bool? AutoAnswerEnabled
  {
      get => autoAnswerEnabled;
      set => autoAnswerEnabled = value;
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

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public int? EmergencyCallMethod
  {
      get => emergencyCallMethod;
      set => emergencyCallMethod = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public bool? IdleReasonRequired
  {
      get => idleReasonRequired;
      set => idleReasonRequired = value;
  }

  public int? LogoutNonActivityTime
  {
      get => logoutNonActivityTime;
      set => logoutNonActivityTime = value;
  }

  public bool? LogoutReasonRequired
  {
      get => logoutReasonRequired;
      set => logoutReasonRequired = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public int? PlayZipTone
  {
      get => playZipTone;
      set => playZipTone = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public int? RemoteAgentType
  {
      get => remoteAgentType;
      set => remoteAgentType = value;
  }

  public int? SupervisorAssistCallMethod
  {
      get => supervisorAssistCallMethod;
      set => supervisorAssistCallMethod = value;
  }

  public int? WorkModeTimer
  {
      get => workModeTimer;
      set => workModeTimer = value;
  }

  public int? WrapupDataIncomingMode
  {
      get => wrapupDataIncomingMode;
      set => wrapupDataIncomingMode = value;
  }

  public int? WrapupDataOutgoingMode
  {
      get => wrapupDataOutgoingMode;
      set => wrapupDataOutgoingMode = value;
  }

  public int? AcdSharedLineUsage { get; set; }

  // Path("agentdesksetting")
  [XmlRoot("results")]
  public class AgentDeskSettingList : BaseApiListBean<AgentDeskSetting> {    public override List<AgentDeskSetting>? GetItems() => items;

    public override void SetItems(List<AgentDeskSetting>? value) => items = value;

  }
}

}