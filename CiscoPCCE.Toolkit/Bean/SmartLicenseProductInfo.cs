using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("smartlicense")
[XmlRoot("smartlicenseproductinfo")]
public class SmartLicenseProductInfo : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private int? privacyEnabled;
  private string? productDescription;
  private string? productDisplayName;
  private int? productEnvironment;
  private string? productTag;
  private string? productVersion;
  private string? refURL;
  private int? smartLicenseProductID;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
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

  public int? PrivacyEnabled
  {
      get => privacyEnabled;
      set => privacyEnabled = value;
  }

  public string? ProductDescription
  {
      get => productDescription;
      set => productDescription = value;
  }

  public string? ProductDisplayName
  {
      get => productDisplayName;
      set => productDisplayName = value;
  }

  public int? ProductEnvironment
  {
      get => productEnvironment;
      set => productEnvironment = value;
  }

  public string? ProductTag
  {
      get => productTag;
      set => productTag = value;
  }

  public string? ProductVersion
  {
      get => productVersion;
      set => productVersion = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public int? SmartLicenseProductID
  {
      get => smartLicenseProductID;
      set => smartLicenseProductID = value;
  }

  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseProductInfoList : BaseApiListBean<SmartLicenseProductInfo> {    public override List<SmartLicenseProductInfo>? GetItems() => items;

    public override void SetItems(List<SmartLicenseProductInfo>? value) => items = value;

  }
}

}