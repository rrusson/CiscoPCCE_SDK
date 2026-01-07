using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class DeploymentTaskInfo : BaseApiBean {
  private string? name;
  private bool? passing;

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public bool? Passing
  {
      get => passing;
      set => passing = value;
  }


  public void setPassing(Boolean passing) {
     this.passing = passing;
  }


}

}