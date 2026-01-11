// ----------------------------------------------
package com.cisco.ccbu.cce.unifiedconfig.toolkit.bean;

import com.cisco.ccbu.cce.unifiedconfig.toolkit.BaseApiBean;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.ws.rs.Path;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.List;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.ReferenceBean;
import java.util.Date;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.BaseApiListBean;

import javax.xml.bind.annotation.XmlElement;

import javax.xml.bind.annotation.XmlElementWrapper;


@Path("systemmgmt")
@XmlRootElement(name="inventoryautodiscovery")
public class InventoryAutoDiscovery extends BaseApiBean {
  private boolean disabled;

  public boolean getDisabled() {
     return this.disabled;
  }

  public void setDisabled(boolean disabled) {
     this.disabled = disabled;
  }


  @Path("systemmgmt")
  @XmlRootElement(name = "results")
  public static class InventoryAutoDiscoveryList extends BaseApiListBean<InventoryAutoDiscovery> {
    @XmlElementWrapper(name = "inventoryautodiscoverys")
    @XmlElement(name = "inventoryautodiscovery")
    public List<InventoryAutoDiscovery> getItems() {
      return items;
    }

    public void setItems(List<InventoryAutoDiscovery> items) {
      this.items = items;
    }
  }
}
