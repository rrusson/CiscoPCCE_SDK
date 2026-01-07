using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("WrapUpReason")]
public class WrapUpReasonsConfig : BaseApiBean {
  private string? forAll;
  private string? label;
  private string? uri;

  public string? ForAll
  {
      get => forAll;
      set => forAll = value;
  }


  public void setForAll(String forAll) {
     this.forAll = forAll;
  }

  public string? Label
  {
      get => label;
      set => label = value;
  }


  public void setLabel(String label) {
     this.label = label;
  }

  public string? Uri
  {
      get => uri;
      set => uri = value;
  }


  public void setUri(String uri) {
     this.uri = uri;
  }


}

}