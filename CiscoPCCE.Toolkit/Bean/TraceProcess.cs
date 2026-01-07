using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class TraceProcess : BaseApiBean {
  private string? name;
  private int? value;

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public int? Value
  {
      get => value;
      set => value = value;
  }


  public void setValue(int? value) {
     this.value = value;
  }


}

}