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
@XmlRootElement(name="results")
public class DCAwareRoutingTypeBeanList extends BaseApiBean {
  private DatacenterRoutingTypeBeanList datacenterRoutingTypes;
  private RoutingTypeBeanList routingTypes;

  public DatacenterRoutingTypeBeanList getDatacenterRoutingTypes() {
     return this.datacenterRoutingTypes;
  }

  public void setDatacenterRoutingTypes(DatacenterRoutingTypeBeanList datacenterRoutingTypes) {
     this.datacenterRoutingTypes = datacenterRoutingTypes;
  }

  public RoutingTypeBeanList getRoutingTypes() {
     return this.routingTypes;
  }

  public void setRoutingTypes(RoutingTypeBeanList routingTypes) {
     this.routingTypes = routingTypes;
  }


  @Path("routingtype")
  @XmlRootElement(name = "results")
  public static class DCAwareRoutingTypeBeanListList extends BaseApiListBean<DCAwareRoutingTypeBeanList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<DCAwareRoutingTypeBeanList> getItems() {
      return items;
    }

    public void setItems(List<DCAwareRoutingTypeBeanList> items) {
      this.items = items;
    }
  }
}
