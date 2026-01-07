using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("personalcallback")
[XmlRoot("personalCallback")]
public class PersonalCallback : BaseApiBean {
  private string? delimiter;
  private string? fileContent;
  private bool? overwriteData;

  public string? Delimiter
  {
      get => delimiter;
      set => delimiter = value;
  }


  public void setDelimiter(String delimiter) {
     this.delimiter = delimiter;
  }

  public string? FileContent
  {
      get => fileContent;
      set => fileContent = value;
  }


  public void setFileContent(String fileContent) {
     this.fileContent = fileContent;
  }

  public bool? OverwriteData
  {
      get => overwriteData;
      set => overwriteData = value;
  }


  public void setOverwriteData(bool? overwriteData) {
     this.overwriteData = overwriteData;
  }


  // Path("personalcallback")
  [XmlRoot("results")]
  public class PersonalCallbackList : BaseApiListBean<PersonalCallback> {
    [XmlElement("personalCallbacks")]
    [XmlElement("personalCallback")]
   
    public override List<PersonalCallback>? GetItems() => items;

    public override void SetItems(List<PersonalCallback>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PersonalCallback>? items)
    {
        this.items = items;
    }
  }
}

}