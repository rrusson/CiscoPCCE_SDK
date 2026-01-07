using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class Alert : BaseApiBean {
  private ApiErrors errors;
  private Machine machine;

  [XmlElement("apiErrors")]
  public ApiErrors Errors
  {
      get => errors;
      set => errors = value;
  }


  public void setErrors(ApiErrors errors) {
     this.errors = errors;
  }

  public Machine Machine
  {
      get => machine;
      set => machine = value;
  }


  public void setMachine(Machine machine) {
     this.machine = machine;
  }


}

}