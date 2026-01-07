using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("applicationgatewayglobalsetting")
[XmlRoot("applicationGatewayGlobalSetting")]
public class ApplicationGatewayGlobals : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private ConnectionParametersGlobal connectionParameters;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private ApplicationGatewayType type;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ConnectionParametersGlobal ConnectionParameters
  {
      get => connectionParameters;
      set => connectionParameters = value;
  }


  public void setConnectionParameters(ConnectionParametersGlobal connectionParameters) {
     this.connectionParameters = connectionParameters;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public ApplicationGatewayType Type
  {
      get => type;
      set => type = value;
  }


  public void setType(ApplicationGatewayType type) {
     this.type = type;
  }


  // Path("applicationgatewayglobalsetting")
  [XmlRoot("results")]
  public class ApplicationGatewayGlobalsList : BaseApiListBean<ApplicationGatewayGlobals> {
    [XmlElement("applicationGatewayGlobalSettings")]
    [XmlElement("applicationGatewayGlobalSetting")]
   
    public override List<ApplicationGatewayGlobals>? GetItems() => items;

    public override void SetItems(List<ApplicationGatewayGlobals>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ApplicationGatewayGlobals>? items)
    {
        this.items = items;
    }
  }
}

}