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


@Path("machineinventory")
@XmlRootElement(name="speechConfig")
public class CVAConfigInfo extends BaseApiBean {
  private String version;

  @XmlElement(name="version")
  public String getVersion() {
     return this.version;
  }

  public void setVersion(String version) {
     this.version = version;
  }


  @Path("machineinventory")
  @XmlRootElement(name = "results")
  public static class CVAConfigInfoList extends BaseApiListBean<CVAConfigInfo> {
    @XmlElementWrapper(name = "speechConfigs")
    @XmlElement(name = "speechConfig")
    public List<CVAConfigInfo> getItems() {
      return items;
    }

    public void setItems(List<CVAConfigInfo> items) {
      this.items = items;
    }
  }
}
