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


  public void setApiErrors(ApiErrors apiErrors) {
     this.apiErrors = apiErrors;
  }

  public ChangeSetElement ChangeSetElement
  {
      get => changeSetElement;
      set => changeSetElement = value;
  }


  public void setChangeSetElement(ChangeSetElement changeSetElement) {
     this.changeSetElement = changeSetElement;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("operation")
  [XmlRoot("results")]
  public class ResourceErrorDetailList : BaseApiListBean<ResourceErrorDetail> {
    [XmlElement("errorDetails")]
    [XmlElement("errorDetail")]
   
    public override List<ResourceErrorDetail>? GetItems() => items;

    public override void SetItems(List<ResourceErrorDetail>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ResourceErrorDetail>? items)
    {
        this.items = items;
    }
  }
}

}