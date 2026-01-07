using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("globalsetting")
[XmlRoot("script")]
public class ScriptGlobalSetting : BaseApiBean {
  private short? retainScriptVersion;

  public short? RetainScriptVersion
  {
      get => retainScriptVersion;
      set => retainScriptVersion = value;
  }

  // Path("globalsetting")
  [XmlRoot("results")]
  public class ScriptGlobalSettingList : BaseApiListBean<ScriptGlobalSetting> {    public override List<ScriptGlobalSetting>? GetItems() => items;

    public override void SetItems(List<ScriptGlobalSetting>? value) => items = value;

  }
}

}