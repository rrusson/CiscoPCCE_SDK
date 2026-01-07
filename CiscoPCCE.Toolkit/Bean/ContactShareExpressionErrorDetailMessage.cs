using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("contactsharerule")
[XmlRoot("expressionError")]
public class ContactShareExpressionErrorDetailMessage : BaseApiBean {
  private string? data;
  private string? type;

  public string? Data
  {
      get => data;
      set => data = value;
  }


  public void setData(String data) {
     this.data = data;
  }

  public string? Type
  {
      get => type;
      set => type = value;
  }


  public void setType(String type) {
     this.type = type;
  }


  // Path("contactsharerule")
  [XmlRoot("results")]
  public class ContactShareExpressionErrorDetailMessageList : BaseApiListBean<ContactShareExpressionErrorDetailMessage> {
    [XmlElement("expressionErrors")]
    [XmlElement("expressionError")]
   
    public override List<ContactShareExpressionErrorDetailMessage>? GetItems() => items;

    public override void SetItems(List<ContactShareExpressionErrorDetailMessage>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ContactShareExpressionErrorDetailMessage>? items)
    {
        this.items = items;
    }
  }
}

}