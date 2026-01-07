using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("contactsharerule")
[XmlRoot("errorDetail")]
public class ContactShareExpressionErrorDetail : BaseApiBean {
  private List<ContactShareExpressionErrorDetailMessage>? expressionErrors;

  [XmlElement("expressionErrors")]
  [XmlElement("expressionError")]
  public List<ContactShareExpressionErrorDetailMessage>? ExpressionErrors
  {
      get => expressionErrors;
      set => expressionErrors = value;
  }


  public void setExpressionErrors(List<ContactShareExpressionErrorDetailMessage> expressionErrors) {
     this.expressionErrors = expressionErrors;
  }


  // Path("contactsharerule")
  [XmlRoot("results")]
  public class ContactShareExpressionErrorDetailList : BaseApiListBean<ContactShareExpressionErrorDetail> {
    [XmlElement("errorDetails")]
    [XmlElement("errorDetail")]
   
    public override List<ContactShareExpressionErrorDetail>? GetItems() => items;

    public override void SetItems(List<ContactShareExpressionErrorDetail>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ContactShareExpressionErrorDetail>? items)
    {
        this.items = items;
    }
  }
}

}