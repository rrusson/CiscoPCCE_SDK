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


  public void setClient_id(String client_id) {
     this.client_id = client_id;
  }

  public string? Client_secret
  {
      get => client_secret;
      set => client_secret = value;
  }


  public void setClient_secret(String client_secret) {
     this.client_secret = client_secret;
  }

  public string? Cluster_mode
  {
      get => cluster_mode;
      set => cluster_mode = value;
  }


  public void setCluster_mode(String cluster_mode) {
     this.cluster_mode = cluster_mode;
  }

  public string? Cluster_name
  {
      get => cluster_name;
      set => cluster_name = value;
  }


  public void setCluster_name(String cluster_name) {
     this.cluster_name = cluster_name;
  }

  public string? Default_ids_ref
  {
      get => default_ids_ref;
      set => default_ids_ref = value;
  }


  public void setDefault_ids_ref(String default_ids_ref) {
     this.default_ids_ref = default_ids_ref;
  }

  public string? Ids1_url
  {
      get => ids1_url;
      set => ids1_url = value;
  }


  public void setIds1_url(String ids1_url) {
     this.ids1_url = ids1_url;
  }

  public string? Ids2_url
  {
      get => ids2_url;
      set => ids2_url = value;
  }


  public void setIds2_url(String ids2_url) {
     this.ids2_url = ids2_url;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? Redirect_base_uri
  {
      get => redirect_base_uri;
      set => redirect_base_uri = value;
  }


  public void setRedirect_base_uri(String redirect_base_uri) {
     this.redirect_base_uri = redirect_base_uri;
  }

  public string? Resource_id
  {
      get => resource_id;
      set => resource_id = value;
  }


  public void setResource_id(String resource_id) {
     this.resource_id = resource_id;
  }

  public string? Resource_secret
  {
      get => resource_secret;
      set => resource_secret = value;
  }


  public void setResource_secret(String resource_secret) {
     this.resource_secret = resource_secret;
  }


  // Path("sso")
  [XmlRoot("results")]
  public class SsoConfigBeanList : BaseApiListBean<SsoConfigBean> {
    [XmlElement("SsoConfigs")]
    [XmlElement("SsoConfig")]
   
    public override List<SsoConfigBean>? GetItems() => items;

    public override void SetItems(List<SsoConfigBean>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SsoConfigBean>? items)
    {
        this.items = items;
    }
  }
}

}