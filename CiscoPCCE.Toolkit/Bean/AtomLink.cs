using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class AtomLink : BaseApiBean {
  private string? href;
  private string? rel;
  private string? type;

  public string? Href
  {
      get => href;
      set => href = value;
  }


  public void setHref(String href) {
     this.href = href;
  }

  public string? Rel
  {
      get => rel;
      set => rel = value;
  }


  public void setRel(String rel) {
     this.rel = rel;
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