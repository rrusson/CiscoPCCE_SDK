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

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public CallGlobalSetting CallReporting
  {
      get => callReporting;
      set => callReporting = value;
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

  [XmlElement("datacenterSettings")]
  [XmlElement("datacenterSetting")]
  public List<DataCenterSetting>? DataCenterSettingList
  {
      get => dataCenterSettingList;
      set => dataCenterSettingList = value;
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

  public NetworkLabelGlobalSetting Labels
  {
      get => labels;
      set => labels = value;
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

  public ReportingGlobalSetting Reporting
  {
      get => reporting;
      set => reporting = value;
  }

  public ScriptGlobalSetting Script
  {
      get => script;
      set => script = value;
  }

  // Path("globalsetting")
  [XmlRoot("results")]
  public class GlobalSettingList : BaseApiListBean<GlobalSetting> {    public override List<GlobalSetting>? GetItems() => items;

    public override void SetItems(List<GlobalSetting>? value) => items = value;

  }
}

}