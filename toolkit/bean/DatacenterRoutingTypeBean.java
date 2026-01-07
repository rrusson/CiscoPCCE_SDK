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


@Path("routingtype")
@XmlRootElement(name="datacenterRoutingType")
public class DatacenterRoutingTypeBean extends BaseApiBean {
  private ReferenceBean datacenter;
  private ReferenceBean peripheralSet;
  private RoutingTypeBeanList routingTypes;

  public ReferenceBean getDatacenter() {
     return this.datacenter;
  }

  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
  }

  public ReferenceBean getPeripheralSet() {
     return this.peripheralSet;
  }

  public void setPeripheralSet(ReferenceBean peripheralSet) {
     this.peripheralSet = peripheralSet;
  }

  public RoutingTypeBeanList getRoutingTypes() {
     return this.routingTypes;
  }

  public void setRoutingTypes(RoutingTypeBeanList routingTypes) {
     this.routingTypes = routingTypes;
  }


  @Path("routingtype")
  @XmlRootElement(name = "results")
  public static class DatacenterRoutingTypeBeanList extends BaseApiListBean<DatacenterRoutingTypeBean> {
    @XmlElementWrapper(name = "datacenterRoutingTypes")
    @XmlElement(name = "datacenterRoutingType")
    public List<DatacenterRoutingTypeBean> getItems() {
      return items;
    }

    public void setItems(List<DatacenterRoutingTypeBean> items) {
      this.items = items;
    }
  }
}
