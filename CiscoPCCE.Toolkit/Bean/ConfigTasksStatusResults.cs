using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("results")]
public class ConfigTasksStatusResults : BaseApiBean {
  private StateEnum state;

  [XmlElement("state")]
  public StateEnum State
  {
      get => state;
      set => state = value;
  }


  public void setState(StateEnum state) {
     this.state = state;
  }


}

}