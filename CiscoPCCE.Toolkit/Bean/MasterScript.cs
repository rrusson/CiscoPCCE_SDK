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

  public int? CurrentVersion
  {
      get => currentVersion;
      set => currentVersion = value;
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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
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

  public ScriptVersion Script
  {
      get => script;
      set => script = value;
  }

  public int? ScriptType
  {
      get => scriptType;
      set => scriptType = value;
  }

  [XmlElement("##default")]
  [XmlElement("scriptVersion")]
  public List<ReferenceBean>? ScriptVersions
  {
      get => scriptVersions;
      set => scriptVersions = value;
  }

  // Path("masterscript")
  [XmlRoot("results")]
  public class MasterScriptList : BaseApiListBean<MasterScript> {    public override List<MasterScript>? GetItems() => items;

    public override void SetItems(List<MasterScript>? value) => items = value;

  }
}

}