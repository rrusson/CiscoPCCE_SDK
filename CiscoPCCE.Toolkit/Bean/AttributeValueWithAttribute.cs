using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class AttributeValueWithAttribute : BaseApiBean {
  private ReferenceBean attribute;
  private string? attributeValue;
  private string? description;

  public ReferenceBean Attribute
  {
      get => attribute;
      set => attribute = value;
  }


  public void setAttribute(ReferenceBean attribute) {
     this.attribute = attribute;
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