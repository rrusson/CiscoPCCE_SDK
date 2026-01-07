using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("application")]
public class Application : BaseApiBean {
                    
  public string? ApplicationName { get; set; }

  public string? Description { get; set; }

  public string? Enabled { get; set; }

  public ICMPostRouting ICMPostRouting { get; set; }

  public ICMTranslationRouting ICMTranslationRouting { get; set; }

  public int? Id { get; set; }

  public int Maxsession { get; set; }

  public ScriptApplication ScriptApplication { get; set; }

  public string? Self { get; set; }

  public string? Type { get; set; }

}

}