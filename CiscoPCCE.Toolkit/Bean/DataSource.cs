using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("cloudconnectsettings")
[XmlRoot("dataSource")]
public class DataSource : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? correlationId;
  private ReferenceBean department;
  private int? id;
  private string? idFromRefUrl;
  private string? refURL;
  private DataSourceDetails sideA;
  private DataSourceDetails sideB;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
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

  public int? Id
  {
      get => id;
      set => id = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public DataSourceDetails SideA
  {
      get => sideA;
      set => sideA = value;
  }

  public DataSourceDetails SideB
  {
      get => sideB;
      set => sideB = value;
  }

  // Path("cloudconnectsettings")
  [XmlRoot("results")]
  public class DataSourceList : BaseApiListBean<DataSource> {    public override List<DataSource>? GetItems() => items;

    public override void SetItems(List<DataSource>? value) => items = value;

  }
}

}