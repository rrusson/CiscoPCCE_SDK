using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class CollectionValue : BaseApiBean {
  private string? label;
  private string? value;

  public string? Label
  {
      get => label;
      set => label = value;
  }


  public void setLabel(String label) {
     this.label = label;
  }

  public string? Value
  {
      get => value;
      set => value = value;
  }


  public void setValue(String value) {
     this.value = value;
  }


}

}