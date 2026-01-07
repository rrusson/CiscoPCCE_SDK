using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("globalsetting")
[XmlRoot("script")]
public class ScriptGlobalSetting : BaseApiBean {
  private Short retainScriptVersion;

  public Short RetainScriptVersion
  {
      get => retainScriptVersion;
      set => retainScriptVersion = value;
  }


  public void setRetainScriptVersion(Short retainScriptVersion) {
     this.retainScriptVersion = retainScriptVersion;
  }


  // Path("globalsetting")
  [XmlRoot("results")]
  public class ScriptGlobalSettingList : BaseApiListBean<ScriptGlobalSetting> {
    [XmlElement("scripts")]
    [XmlElement("script")]
   
    public override List<ScriptGlobalSetting>? GetItems() => items;

    public override void SetItems(List<ScriptGlobalSetting>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ScriptGlobalSetting>? items)
    {
        this.items = items;
    }
  }
}

}