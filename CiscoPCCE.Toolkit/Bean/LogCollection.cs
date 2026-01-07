using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("logcollection")
[XmlRoot("logCollection")]
public class LogCollection : BaseApiBean {
  private Set components;
  private string? description;
  private long? endDateTime;
  private string? refURL;
  private FileRefWithSize resultsFile;
  private long? startDateTime;
  private Status status;

  [XmlElement("components")]
  [XmlElement("component")]
  public Set Components
  {
      get => components;
      set => components = value;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public long? EndDateTime
  {
      get => endDateTime;
      set => endDateTime = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  [XmlElement("##default")]
  public FileRefWithSize ResultsFile
  {
      get => resultsFile;
      set => resultsFile = value;
  }

  public long? StartDateTime
  {
      get => startDateTime;
      set => startDateTime = value;
  }

  public Status Status
  {
      get => status;
      set => status = value;
  }

  // Path("logcollection")
  [XmlRoot("results")]
  public class LogCollectionList : BaseApiListBean<LogCollection> {    public override List<LogCollection>? GetItems() => items;

    public override void SetItems(List<LogCollection>? value) => items = value;

  }
}

}