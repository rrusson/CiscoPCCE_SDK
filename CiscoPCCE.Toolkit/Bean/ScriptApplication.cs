using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ScriptApplication : BaseApiBean {
  private string? defaultScript;
  private string? script;

  public string? DefaultScript
  {
      get => defaultScript;
      set => defaultScript = value;
  }


  public void setDefaultScript(String defaultScript) {
     this.defaultScript = defaultScript;
  }

  public string? Script
  {
      get => script;
      set => script = value;
  }


  public void setScript(String script) {
     this.script = script;
  }


}

}