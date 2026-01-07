using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("internetscripteditor")
[XmlRoot("##default")]
public class InternetScriptEditor : BaseApiBean {
  private string? downloadLink;
  private bool? enabled;

  public string? DownloadLink
  {
      get => downloadLink;
      set => downloadLink = value;
  }

  public bool? Enabled
  {
      get => enabled;
      set => enabled = value;
  }

  // Path("internetscripteditor")
  [XmlRoot("results")]
  public class InternetScriptEditorList : BaseApiListBean<InternetScriptEditor> {    public override List<InternetScriptEditor>? GetItems() => items;

    public override void SetItems(List<InternetScriptEditor>? value) => items = value;

  }
}

}