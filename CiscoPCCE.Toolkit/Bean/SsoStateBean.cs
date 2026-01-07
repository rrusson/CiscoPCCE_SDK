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

  public string? Caching
  {
      get => caching;
      set => caching = value;
  }

  public string? Client_id
  {
      get => client_id;
      set => client_id = value;
  }

  public string? Default_ids_ref
  {
      get => default_ids_ref;
      set => default_ids_ref = value;
  }

  public string? Ids1_state
  {
      get => ids1_state;
      set => ids1_state = value;
  }

  public string? Ids2_state
  {
      get => ids2_state;
      set => ids2_state = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public SsoLocalEnabledState Sso_mode
  {
      get => sso_mode;
      set => sso_mode = value;
  }

  public long? Timestamp
  {
      get => timestamp;
      set => timestamp = value;
  }

  // Path("sso")
  [XmlRoot("results")]
  public class SsoStateBeanList : BaseApiListBean<SsoStateBean> {    public override List<SsoStateBean>? GetItems() => items;

    public override void SetItems(List<SsoStateBean>? value) => items = value;

  }
}

}