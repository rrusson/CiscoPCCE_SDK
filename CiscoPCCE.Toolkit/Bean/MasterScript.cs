using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("masterscript")
[XmlRoot("masterScript")]
public class MasterScript : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private int? currentVersion;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;
  private ScriptVersion script;
  private int? scriptType;
  private List<ReferenceBean>? scriptVersions;

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

  public int? CurrentVersion
  {
      get => currentVersion;
      set => currentVersion = value;
  }


  public void setCurrentVersion(int? currentVersion) {
     this.currentVersion = currentVersion;
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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
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

  public ScriptVersion Script
  {
      get => script;
      set => script = value;
  }


  public void setScript(ScriptVersion script) {
     this.script = script;
  }

  public int? ScriptType
  {
      get => scriptType;
      set => scriptType = value;
  }


  public void setScriptType(int? scriptType) {
     this.scriptType = scriptType;
  }

  [XmlElement("##default")]
  [XmlElement("scriptVersion")]
  public List<ReferenceBean>? ScriptVersions
  {
      get => scriptVersions;
      set => scriptVersions = value;
  }


  public void setScriptVersions(List<ReferenceBean> scriptVersions) {
     this.scriptVersions = scriptVersions;
  }


  // Path("masterscript")
  [XmlRoot("results")]
  public class MasterScriptList : BaseApiListBean<MasterScript> {
    [XmlElement("masterScripts")]
    [XmlElement("masterScript")]
   
    public override List<MasterScript>? GetItems() => items;

    public override void SetItems(List<MasterScript>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<MasterScript>? items)
    {
        this.items = items;
    }
  }
}

}