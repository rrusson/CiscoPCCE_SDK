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


  public void setComponents(Set components) {
     this.components = components;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public long? EndDateTime
  {
      get => endDateTime;
      set => endDateTime = value;
  }


  public void setEndDateTime(long? endDateTime) {
     this.endDateTime = endDateTime;
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
  public FileRefWithSize ResultsFile
  {
      get => resultsFile;
      set => resultsFile = value;
  }


  public void setResultsFile(FileRefWithSize resultsFile) {
     this.resultsFile = resultsFile;
  }

  public long? StartDateTime
  {
      get => startDateTime;
      set => startDateTime = value;
  }


  public void setStartDateTime(long? startDateTime) {
     this.startDateTime = startDateTime;
  }

  public Status Status
  {
      get => status;
      set => status = value;
  }


  public void setStatus(Status status) {
     this.status = status;
  }


  // Path("logcollection")
  [XmlRoot("results")]
  public class LogCollectionList : BaseApiListBean<LogCollection> {
    [XmlElement("logCollections")]
    [XmlElement("logCollection")]
   
    public override List<LogCollection>? GetItems() => items;

    public override void SetItems(List<LogCollection>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<LogCollection>? items)
    {
        this.items = items;
    }
  }
}

}