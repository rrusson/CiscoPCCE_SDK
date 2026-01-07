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


  public void setDownloadLink(String downloadLink) {
     this.downloadLink = downloadLink;
  }

  public bool? Enabled
  {
      get => enabled;
      set => enabled = value;
  }


  public void setEnabled(bool? enabled) {
     this.enabled = enabled;
  }


  // Path("internetscripteditor")
  [XmlRoot("results")]
  public class InternetScriptEditorList : BaseApiListBean<InternetScriptEditor> {
    [XmlElement("##defaults")]
    [XmlElement("##default")]
   
    public override List<InternetScriptEditor>? GetItems() => items;

    public override void SetItems(List<InternetScriptEditor>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<InternetScriptEditor>? items)
    {
        this.items = items;
    }
  }
}

}