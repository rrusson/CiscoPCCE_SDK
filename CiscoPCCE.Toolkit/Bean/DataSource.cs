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


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
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

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public DataSourceDetails SideA
  {
      get => sideA;
      set => sideA = value;
  }


  public void setSideA(DataSourceDetails sideA) {
     this.sideA = sideA;
  }

  public DataSourceDetails SideB
  {
      get => sideB;
      set => sideB = value;
  }


  public void setSideB(DataSourceDetails sideB) {
     this.sideB = sideB;
  }


  // Path("cloudconnectsettings")
  [XmlRoot("results")]
  public class DataSourceList : BaseApiListBean<DataSource> {
    [XmlElement("dataSources")]
    [XmlElement("dataSource")]
   
    public override List<DataSource>? GetItems() => items;

    public override void SetItems(List<DataSource>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DataSource>? items)
    {
        this.items = items;
    }
  }
}

}