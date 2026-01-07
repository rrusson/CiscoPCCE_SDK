using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ICMPostRouting : BaseApiBean {
  private string? defaultScript;
  private string? initialScript;
  private int timeout;

  public string? DefaultScript
  {
      get => defaultScript;
      set => defaultScript = value;
  }


  public void setDefaultScript(String defaultScript) {
     this.defaultScript = defaultScript;
  }

  public string? InitialScript
  {
      get => initialScript;
      set => initialScript = value;
  }


  public void setInitialScript(String initialScript) {
     this.initialScript = initialScript;
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