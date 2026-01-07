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

  public ConnectionParametersGlobal ConnectionParameters
  {
      get => connectionParameters;
      set => connectionParameters = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public ApplicationGatewayType Type
  {
      get => type;
      set => type = value;
  }

  // Path("applicationgatewayglobalsetting")
  [XmlRoot("results")]
  public class ApplicationGatewayGlobalsList : BaseApiListBean<ApplicationGatewayGlobals> {    public override List<ApplicationGatewayGlobals>? GetItems() => items;

    public override void SetItems(List<ApplicationGatewayGlobals>? value) => items = value;

  }
}

}