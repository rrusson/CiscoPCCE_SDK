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

  public DateTime? DateTime
  {
      get => dateTime;
      set => dateTime = value;
  }


  public void setDateTime(Date dateTime) {
     this.dateTime = dateTime;
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

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  [XmlElement("##default")]
  [XmlElement("reference")]
  public List<ScriptCrossReference>? References
  {
      get => references;
      set => references = value;
  }


  public void setReferences(List<ScriptCrossReference> references) {
     this.references = references;
  }

  public int? Version
  {
      get => version;
      set => version = value;
  }


  public void setVersion(int? version) {
     this.version = version;
  }


  // Path("masterscript")
  [XmlRoot("results")]
  public class ScriptVersionList : BaseApiListBean<ScriptVersion> {
    [XmlElement("scriptVersions")]
    [XmlElement("scriptVersion")]
   
    public override List<ScriptVersion>? GetItems() => items;

    public override void SetItems(List<ScriptVersion>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ScriptVersion>? items)
    {
        this.items = items;
    }
  }
}

}