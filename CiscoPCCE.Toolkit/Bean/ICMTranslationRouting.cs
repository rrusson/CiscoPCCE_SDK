using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ICMTranslationRouting : BaseApiBean {
  private string? defaultScript;
  private int timeout;

  public string? DefaultScript
  {
      get => defaultScript;
      set => defaultScript = value;
  }


  public void setDefaultScript(String defaultScript) {
     this.defaultScript = defaultScript;
  }

  public int Timeout
  {
      get => timeout;
      set => timeout = value;
  }


  public void setTimeout(int timeout) {
     this.timeout = timeout;
  }


}

}