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

  public string? FileContent
  {
      get => fileContent;
      set => fileContent = value;
  }

  public bool? OverwriteData
  {
      get => overwriteData;
      set => overwriteData = value;
  }

  // Path("personalcallback")
  [XmlRoot("results")]
  public class PersonalCallbackList : BaseApiListBean<PersonalCallback> {    public override List<PersonalCallback>? GetItems() => items;

    public override void SetItems(List<PersonalCallback>? value) => items = value;

  }
}

}