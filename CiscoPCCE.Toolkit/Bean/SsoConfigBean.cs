using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("sso")
[XmlRoot("SsoConfig")]
public class SsoConfigBean : BaseApiBean {
  private string? client_id;
  private string? client_secret;
  private string? cluster_mode;
  private string? cluster_name;
  private string? default_ids_ref;
  private string? ids1_url;
  private string? ids2_url;
  private string? name;
  private string? redirect_base_uri;
  private string? resource_id;
  private string? resource_secret;

  public string? Client_id
  {
      get => client_id;
      set => client_id = value;
  }

  public string? Client_secret
  {
      get => client_secret;
      set => client_secret = value;
  }

  public string? Cluster_mode
  {
      get => cluster_mode;
      set => cluster_mode = value;
  }

  public string? Cluster_name
  {
      get => cluster_name;
      set => cluster_name = value;
  }

  public string? Default_ids_ref
  {
      get => default_ids_ref;
      set => default_ids_ref = value;
  }

  public string? Ids1_url
  {
      get => ids1_url;
      set => ids1_url = value;
  }

  public string? Ids2_url
  {
      get => ids2_url;
      set => ids2_url = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public string? Redirect_base_uri
  {
      get => redirect_base_uri;
      set => redirect_base_uri = value;
  }

  public string? Resource_id
  {
      get => resource_id;
      set => resource_id = value;
  }

  public string? Resource_secret
  {
      get => resource_secret;
      set => resource_secret = value;
  }

  // Path("sso")
  [XmlRoot("results")]
  public class SsoConfigBeanList : BaseApiListBean<SsoConfigBean> {    public override List<SsoConfigBean>? GetItems() => items;

    public override void SetItems(List<SsoConfigBean>? value) => items = value;

  }
}

}