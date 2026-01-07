using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class AdExceptionErrorDetail : BaseApiBean {
  private int code;
  private string? key;
  private string? value;

  public int Code
  {
      get => code;
      set => code = value;
  }


  public void setCode(int code) {
     this.code = code;
  }

  public string? Key
  {
      get => key;
      set => key = value;
  }


  public void setKey(String key) {
     this.key = key;
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