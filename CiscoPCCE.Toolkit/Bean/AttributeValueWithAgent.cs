using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class AttributeValueWithAgent : BaseApiBean {
  private ReferenceBean agent;
  private string? attributeValue;
  private string? description;

  public ReferenceBean Agent
  {
      get => agent;
      set => agent = value;
  }


  public void setAgent(ReferenceBean agent) {
     this.agent = agent;
  }

  public string? AttributeValue
  {
      get => attributeValue;
      set => attributeValue = value;
  }


  public void setAttributeValue(String attributeValue) {
     this.attributeValue = attributeValue;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }


}

}