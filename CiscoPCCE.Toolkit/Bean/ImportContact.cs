using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("import")]
public class ImportContact : BaseApiBean {
      
  public string? Delimiter { get; set; }

  public string? FileContent { get; set; }

  public bool? OverwriteData { get; set; }

}

}