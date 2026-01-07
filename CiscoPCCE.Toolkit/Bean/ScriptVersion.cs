using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("masterscript")
[XmlRoot("scriptVersion")]
public class ScriptVersion : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private DateTime? dateTime;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private string? refURL;
  private List<ScriptCrossReference>? references;
  private int? version;

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

  public DateTime? DateTime
  {
      get => dateTime;
      set => dateTime = value;
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

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  [XmlElement("##default")]
  [XmlElement("reference")]
  public List<ScriptCrossReference>? References
  {
      get => references;
      set => references = value;
  }

  public int? Version
  {
      get => version;
      set => version = value;
  }

  // Path("masterscript")
  [XmlRoot("results")]
  public class ScriptVersionList : BaseApiListBean<ScriptVersion> {    public override List<ScriptVersion>? GetItems() => items;

    public override void SetItems(List<ScriptVersion>? value) => items = value;

  }
}

}