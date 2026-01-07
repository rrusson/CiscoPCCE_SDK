using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("sso")
[XmlRoot("SsoState")]
public class SsoStateBean : BaseApiBean {
  private string? active_ids;
  private string? caching;
  private string? client_id;
  private string? default_ids_ref;
  private string? ids1_state;
  private string? ids2_state;
  private string? name;
  private SsoLocalEnabledState sso_mode;
  private long? timestamp;

  public string? Active_ids
  {
      get => active_ids;
      set => active_ids = value;
  }


  public void setActive_ids(String active_ids) {
     this.active_ids = active_ids;
  }

  public string? Caching
  {
      get => caching;
      set => caching = value;
  }


  public void setCaching(String caching) {
     this.caching = caching;
  }

  public string? Client_id
  {
      get => client_id;
      set => client_id = value;
  }


  public void setClient_id(String client_id) {
     this.client_id = client_id;
  }

  public string? Default_ids_ref
  {
      get => default_ids_ref;
      set => default_ids_ref = value;
  }


  public void setDefault_ids_ref(String default_ids_ref) {
     this.default_ids_ref = default_ids_ref;
  }

  public string? Ids1_state
  {
      get => ids1_state;
      set => ids1_state = value;
  }


  public void setIds1_state(String ids1_state) {
     this.ids1_state = ids1_state;
  }

  public string? Ids2_state
  {
      get => ids2_state;
      set => ids2_state = value;
  }


  public void setIds2_state(String ids2_state) {
     this.ids2_state = ids2_state;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public SsoLocalEnabledState Sso_mode
  {
      get => sso_mode;
      set => sso_mode = value;
  }


  public void setSso_mode(SsoLocalEnabledState sso_mode) {
     this.sso_mode = sso_mode;
  }

  public long? Timestamp
  {
      get => timestamp;
      set => timestamp = value;
  }


  public void setTimestamp(long? timestamp) {
     this.timestamp = timestamp;
  }


  // Path("sso")
  [XmlRoot("results")]
  public class SsoStateBeanList : BaseApiListBean<SsoStateBean> {
    [XmlElement("SsoStates")]
    [XmlElement("SsoState")]
   
    public override List<SsoStateBean>? GetItems() => items;

    public override void SetItems(List<SsoStateBean>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SsoStateBean>? items)
    {
        this.items = items;
    }
  }
}

}