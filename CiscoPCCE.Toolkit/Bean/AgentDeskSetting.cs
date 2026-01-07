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


  public void setAgentStateAfterRONA(AgentStateAfterRONAEnum agentStateAfterRONA) {
     this.agentStateAfterRONA = agentStateAfterRONA;
  }

  public bool? AutoAnswerEnabled
  {
      get => autoAnswerEnabled;
      set => autoAnswerEnabled = value;
  }


  public void setAutoAnswerEnabled(Boolean autoAnswerEnabled) {
     this.autoAnswerEnabled = autoAnswerEnabled;
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

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public int? EmergencyCallMethod
  {
      get => emergencyCallMethod;
      set => emergencyCallMethod = value;
  }


  public void setEmergencyCallMethod(int? emergencyCallMethod) {
     this.emergencyCallMethod = emergencyCallMethod;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? IdleReasonRequired
  {
      get => idleReasonRequired;
      set => idleReasonRequired = value;
  }


  public void setIdleReasonRequired(Boolean idleReasonRequired) {
     this.idleReasonRequired = idleReasonRequired;
  }

  public int? LogoutNonActivityTime
  {
      get => logoutNonActivityTime;
      set => logoutNonActivityTime = value;
  }


  public void setLogoutNonActivityTime(int? logoutNonActivityTime) {
     this.logoutNonActivityTime = logoutNonActivityTime;
  }

  public bool? LogoutReasonRequired
  {
      get => logoutReasonRequired;
      set => logoutReasonRequired = value;
  }


  public void setLogoutReasonRequired(Boolean logoutReasonRequired) {
     this.logoutReasonRequired = logoutReasonRequired;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public int? PlayZipTone
  {
      get => playZipTone;
      set => playZipTone = value;
  }


  public void setPlayZipTone(int? playZipTone) {
     this.playZipTone = playZipTone;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? RemoteAgentType
  {
      get => remoteAgentType;
      set => remoteAgentType = value;
  }


  public void setRemoteAgentType(int? remoteAgentType) {
     this.remoteAgentType = remoteAgentType;
  }

  public int? SupervisorAssistCallMethod
  {
      get => supervisorAssistCallMethod;
      set => supervisorAssistCallMethod = value;
  }


  public void setSupervisorAssistCallMethod(int? supervisorAssistCallMethod) {
     this.supervisorAssistCallMethod = supervisorAssistCallMethod;
  }

  public int? WorkModeTimer
  {
      get => workModeTimer;
      set => workModeTimer = value;
  }


  public void setWorkModeTimer(int? workModeTimer) {
     this.workModeTimer = workModeTimer;
  }

  public int? WrapupDataIncomingMode
  {
      get => wrapupDataIncomingMode;
      set => wrapupDataIncomingMode = value;
  }


  public void setWrapupDataIncomingMode(int? wrapupDataIncomingMode) {
     this.wrapupDataIncomingMode = wrapupDataIncomingMode;
  }

  public int? WrapupDataOutgoingMode
  {
      get => wrapupDataOutgoingMode;
      set => wrapupDataOutgoingMode = value;
  }


  public void setWrapupDataOutgoingMode(int? wrapupDataOutgoingMode) {
     this.wrapupDataOutgoingMode = wrapupDataOutgoingMode;
  }

  public int? acdSharedLineUsage
  {
      get => acdSharedLineUsage;
      set => acdSharedLineUsage = value;
  }


  public void setacdSharedLineUsage(int? acdSharedLineUsage) {
     this.acdSharedLineUsage = acdSharedLineUsage;
  }


  // Path("agentdesksetting")
  [XmlRoot("results")]
  public class AgentDeskSettingList : BaseApiListBean<AgentDeskSetting> {
    [XmlElement("agentDeskSettings")]
    [XmlElement("agentDeskSetting")]
   
    public override List<AgentDeskSetting>? GetItems() => items;

    public override void SetItems(List<AgentDeskSetting>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AgentDeskSetting>? items)
    {
        this.items = items;
    }
  }
}

}