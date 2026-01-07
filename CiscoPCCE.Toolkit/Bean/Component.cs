using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class Component : BaseApiBean {
  private TraceLevelEnum level;
  private List<TraceMachine>? traceMachines;
  private ProductEnum type;

  public TraceLevelEnum Level
  {
      get => level;
      set => level = value;
  }


  public void setLevel(TraceLevelEnum level) {
     this.level = level;
  }

  [XmlElement("traceMachines")]
  [XmlElement("traceMachine")]
  public List<TraceMachine>? TraceMachines
  {
      get => traceMachines;
      set => traceMachines = value;
  }


  public void setTraceMachines(List<TraceMachine> traceMachines) {
     this.traceMachines = traceMachines;
  }

  public ProductEnum Type
  {
      get => type;
      set => type = value;
  }


  public void setType(ProductEnum type) {
     this.type = type;
  }


}

}