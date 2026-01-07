using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("ClusterConfig")]
public class ClusterConfig : BaseApiBean {
  private SecondaryNode secondaryNode;

  public SecondaryNode SecondaryNode
  {
      get => secondaryNode;
      set => secondaryNode = value;
  }


  public void setSecondaryNode(SecondaryNode secondaryNode) {
     this.secondaryNode = secondaryNode;
  }


}

}