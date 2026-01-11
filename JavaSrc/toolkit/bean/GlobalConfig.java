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


@Path("contactcenterai")
@XmlRootElement(name="globalConfig")
public class GlobalConfig extends BaseApiBean {
  private String name;
  private String value;

  public String getName() {
     return this.name;
  }

  public void setName(String name) {
     this.name = name;
  }

  public String getValue() {
     return this.value;
  }

  public void setValue(String value) {
     this.value = value;
  }


  @Path("contactcenterai")
  @XmlRootElement(name = "results")
  public static class GlobalConfigList extends BaseApiListBean<GlobalConfig> {
    @XmlElementWrapper(name = "globalConfigs")
    @XmlElement(name = "globalConfig")
    public List<GlobalConfig> getItems() {
      return items;
    }

    public void setItems(List<GlobalConfig> items) {
      this.items = items;
    }
  }
}
