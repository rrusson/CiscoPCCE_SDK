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

  public string? Type
  {
      get => type;
      set => type = value;
  }

  // Path("contactsharerule")
  [XmlRoot("results")]
  public class ContactShareExpressionErrorDetailMessageList : BaseApiListBean<ContactShareExpressionErrorDetailMessage> {    public override List<ContactShareExpressionErrorDetailMessage>? GetItems() => items;

    public override void SetItems(List<ContactShareExpressionErrorDetailMessage>? value) => items = value;

  }
}

}