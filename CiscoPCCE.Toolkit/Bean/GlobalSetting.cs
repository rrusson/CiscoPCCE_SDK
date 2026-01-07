using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("globalsetting")
[XmlRoot("globalSettings")]
public class GlobalSetting : BaseApiBean {
  private AgentGlobalSetting agent;
  private string? baseUrlfromRefUrl;
  private CallGlobalSetting callReporting;
  private int? changeStamp;
  private string? correlationId;
  private List<DataCenterSetting>? dataCenterSettingList;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private NetworkLabelGlobalSetting labels;
  private PermissionInfo permissionInfo;
  private string? refURL;
  private ReportingGlobalSetting reporting;
  private ScriptGlobalSetting script;

  public AgentGlobalSetting Agent
  {
      get => agent;
      set => agent = value;
  }


  public void setAgent(AgentGlobalSetting agent) {
     this.agent = agent;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public CallGlobalSetting CallReporting
  {
      get => callReporting;
      set => callReporting = value;
  }


  public void setCallReporting(CallGlobalSetting callReporting) {
     this.callReporting = callReporting;
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

  [XmlElement("datacenterSettings")]
  [XmlElement("datacenterSetting")]
  public List<DataCenterSetting>? DataCenterSettingList
  {
      get => dataCenterSettingList;
      set => dataCenterSettingList = value;
  }


  public void setDataCenterSettingList(List<DataCenterSetting> dataCenterSettingList) {
     this.dataCenterSettingList = dataCenterSettingList;
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

  public NetworkLabelGlobalSetting Labels
  {
      get => labels;
      set => labels = value;
  }


  public void setLabels(NetworkLabelGlobalSetting labels) {
     this.labels = labels;
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

  public ReportingGlobalSetting Reporting
  {
      get => reporting;
      set => reporting = value;
  }


  public void setReporting(ReportingGlobalSetting reporting) {
     this.reporting = reporting;
  }

  public ScriptGlobalSetting Script
  {
      get => script;
      set => script = value;
  }


  public void setScript(ScriptGlobalSetting script) {
     this.script = script;
  }


  // Path("globalsetting")
  [XmlRoot("results")]
  public class GlobalSettingList : BaseApiListBean<GlobalSetting> {
    [XmlElement("globalSettingss")]
    [XmlElement("globalSettings")]
   
    public override List<GlobalSetting>? GetItems() => items;

    public override void SetItems(List<GlobalSetting>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<GlobalSetting>? items)
    {
        this.items = items;
    }
  }
}

}