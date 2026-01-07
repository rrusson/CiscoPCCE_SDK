using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("operation")
[XmlRoot("errorDetail")]
public class ResourceErrorDetail : BaseApiBean {
  private ApiErrors apiErrors;
  private ChangeSetElement changeSetElement;
  private string? refURL;

  public ApiErrors ApiErrors
  {
      get => apiErrors;
      set => apiErrors = value;
  }

  public ChangeSetElement ChangeSetElement
  {
      get => changeSetElement;
      set => changeSetElement = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("operation")
  [XmlRoot("results")]
  public class ResourceErrorDetailList : BaseApiListBean<ResourceErrorDetail> {    public override List<ResourceErrorDetail>? GetItems() => items;

    public override void SetItems(List<ResourceErrorDetail>? value) => items = value;

  }
}

}