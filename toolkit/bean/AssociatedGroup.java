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


@XmlRootElement(name="##default")
public class AssociatedGroup extends BaseApiBean {
  private String groupName;
  private String id;

  public String getGroupName() {
     return this.groupName;
  }

  public void setGroupName(String groupName) {
     this.groupName = groupName;
  }

  public String getId() {
     return this.id;
  }

  public void setId(String id) {
     this.id = id;
  }


}
