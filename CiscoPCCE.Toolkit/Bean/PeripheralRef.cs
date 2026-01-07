using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class PeripheralRef : BaseApiBean {
  private int? id;
  private string? name;

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }


}

}