using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("application")]
public class Application : BaseApiBean {
  private string? applicationName;
  private string? description;
  private string? enabled;
  private ICMPostRouting iCMPostRouting;
  private ICMTranslationRouting iCMTranslationRouting;
  private int? id;
  private int maxsession;
  private ScriptApplication scriptApplication;
  private string? self;
  private string? type;

  public string? ApplicationName
  {
      get => applicationName;
      set => applicationName = value;
  }


  public void setApplicationName(String applicationName) {
     this.applicationName = applicationName;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public string? Enabled
  {
      get => enabled;
      set => enabled = value;
  }


  public void setEnabled(String enabled) {
     this.enabled = enabled;
  }

  public ICMPostRouting ICMPostRouting
  {
      get => iCMPostRouting;
      set => iCMPostRouting = value;
  }


  public void setICMPostRouting(ICMPostRouting iCMPostRouting) {
     this.iCMPostRouting = iCMPostRouting;
  }

  public ICMTranslationRouting ICMTranslationRouting
  {
      get => iCMTranslationRouting;
      set => iCMTranslationRouting = value;
  }


  public void setICMTranslationRouting(ICMTranslationRouting iCMTranslationRouting) {
     this.iCMTranslationRouting = iCMTranslationRouting;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
  }

  public int Maxsession
  {
      get => maxsession;
      set => maxsession = value;
  }


  public void setMaxsession(int maxsession) {
     this.maxsession = maxsession;
  }

  public ScriptApplication ScriptApplication
  {
      get => scriptApplication;
      set => scriptApplication = value;
  }


  public void setScriptApplication(ScriptApplication scriptApplication) {
     this.scriptApplication = scriptApplication;
  }

  public string? Self
  {
      get => self;
      set => self = value;
  }


  public void setSelf(String self) {
     this.self = self;
  }

  public string? Type
  {
      get => type;
      set => type = value;
  }


  public void setType(String type) {
     this.type = type;
  }


}

}