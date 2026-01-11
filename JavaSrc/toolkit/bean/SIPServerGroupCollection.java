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


@XmlRootElement(name="sipServerGroupCollection")
public class SIPServerGroupCollection extends BaseApiBean {
  private List<SIPServerGroupWrapper> sipServerGroupList;

  public List<SIPServerGroupWrapper> getSipServerGroupList() {
     return this.sipServerGroupList;
  }

  public void setSipServerGroupList(List<SIPServerGroupWrapper> sipServerGroupList) {
     this.sipServerGroupList = sipServerGroupList;
  }


}
