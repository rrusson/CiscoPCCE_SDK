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


@Path("agent")
@XmlRootElement(name="results")
public class PersonList extends BaseApiBean {
  private List<Person> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="persons")
  @XmlElement(name="person")
  public List<Person> getItems() {
     return this.items;
  }

  public void setItems(List<Person> items) {
     this.items = items;
  }

  public PageInfo getPageInfo() {
     return this.pageInfo;
  }

  public void setPageInfo(PageInfo pageInfo) {
     this.pageInfo = pageInfo;
  }

  public PermissionInfo getPermissionInfo() {
     return this.permissionInfo;
  }

  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }


  @Path("agent")
  @XmlRootElement(name = "results")
  public static class PersonListList extends BaseApiListBean<PersonList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<PersonList> getItems() {
      return items;
    }

    public void setItems(List<PersonList> items) {
      this.items = items;
    }
  }
}
