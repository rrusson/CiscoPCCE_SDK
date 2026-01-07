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

  [XmlElement("filePath")]
  public string? FilePath
  {
      get => filePath;
      set => filePath = value;
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

  [XmlElement("name")]
  public string? Name
  {
      get => name;
      set => name = value;
  }

  [XmlElement("overwrite")]
  public bool? OverwriteEnabled
  {
      get => overwriteEnabled;
      set => overwriteEnabled = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  [XmlElement("renameFileAfterImport")]
  public bool? RenameEnabled
  {
      get => renameEnabled;
      set => renameEnabled = value;
  }

  // Path("dnc")
  [XmlRoot("results")]
  public class ImportRuleList : BaseApiListBean<ImportRule> {    public override List<ImportRule>? GetItems() => items;

    public override void SetItems(List<ImportRule>? value) => items = value;

  }
}

}