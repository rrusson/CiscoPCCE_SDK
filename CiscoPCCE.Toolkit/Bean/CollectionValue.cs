using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("##default")]
public class CollectionValue : BaseApiBean {
    private string? value;

  public string? Label { get; set; }

  public string? Value
  {
      get => value;
      set => this.value = value;
  }

}

}