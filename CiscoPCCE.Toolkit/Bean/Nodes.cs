using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("nodes")]
public class Nodes : BaseApiBean {
  private List<Node>? nodes;

  public List<Node>? Nodes
  {
      get => nodes;
      set => nodes = value;
  }


  public void setNodes(List<Node> nodes) {
     this.nodes = nodes;
  }


}

}