using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("operation")
[XmlRoot("operations")]
public class Operations : BaseApiBean {
  private List<Operation>? operations;

  [XmlElement("operation")]
  public List<Operation>? OperationList
  {
      get => operations;
      set => operations = value;
  }

  // Path("operation")
  [XmlRoot("results")]
  public class OperationsList : BaseApiListBean<Operations> {    public override List<Operations>? GetItems() => items;

    public override void SetItems(List<Operations>? value) => items = value;

  }
}

}