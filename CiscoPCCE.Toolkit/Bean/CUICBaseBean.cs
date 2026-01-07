using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class CUICBaseBean : BaseApiBean {
  private string? id;

  public string? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(String id) {
     this.id = id;
  }


}

}