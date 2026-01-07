using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("campaign")
[XmlRoot("dnc")]
public class ImportRule : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private string? filePath;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private string? name;
  private bool? overwriteEnabled;
  private string? refURL;
  private bool? renameEnabled;

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

  [XmlElement("filePath")]
  public string? FilePath
  {
      get => filePath;
      set => filePath = value;
  }


  public void setFilePath(String filePath) {
     this.filePath = filePath;
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

  [XmlElement("name")]
  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  [XmlElement("overwrite")]
  public bool? OverwriteEnabled
  {
      get => overwriteEnabled;
      set => overwriteEnabled = value;
  }


  public void setOverwriteEnabled(Boolean overwriteEnabled) {
     this.overwriteEnabled = overwriteEnabled;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  [XmlElement("renameFileAfterImport")]
  public bool? RenameEnabled
  {
      get => renameEnabled;
      set => renameEnabled = value;
  }


  public void setRenameEnabled(Boolean renameEnabled) {
     this.renameEnabled = renameEnabled;
  }


  // Path("dnc")
  [XmlRoot("results")]
  public class ImportRuleList : BaseApiListBean<ImportRule> {
    [XmlElement("dncs")]
    [XmlElement("dnc")]
   
    public override List<ImportRule>? GetItems() => items;

    public override void SetItems(List<ImportRule>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ImportRule>? items)
    {
        this.items = items;
    }
  }
}

}